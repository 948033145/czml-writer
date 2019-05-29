﻿using System;
using JetBrains.Annotations;

namespace CesiumLanguageWriter.Advanced
{
    /// <summary>
    /// Adapts a class derived from <see cref="CesiumPropertyWriter{TDerived}"/> to implement
    /// <see cref="ICesiumValuePropertyWriter{TValue}"/> for a different type of value.  Typically, the
    /// class has a method to write values of the new type, but that method is not exposed via an interface.
    /// This class adapts the method to the interface via a callback delegate.
    /// </summary>
    /// <typeparam name="TFrom">The class derived from <see cref="CesiumPropertyWriter{TDerived}"/> to adapt.</typeparam>
    /// <typeparam name="TValue">The type of value to which to adapt the class to write.</typeparam>
    public class CesiumWriterAdaptor<TFrom, TValue> : ICesiumWriterAdaptor<TFrom>, ICesiumValuePropertyWriter<TValue>, ICesiumDeletablePropertyWriter
        where TFrom : class, ICesiumPropertyWriter
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="parent">The instance to wrap.</param>
        /// <param name="writeValueCallback">The callback to write values of type <typeparamref name="TValue"/>.</param>
        /// <param name="writeDeleteValueCallback">The callback to write an indication that the client should delete existing data.</param>
        public CesiumWriterAdaptor([NotNull] TFrom parent,
                                   [NotNull] CesiumWriterAdaptorWriteCallback<TFrom, TValue> writeValueCallback,
                                   [NotNull] CesiumWriterAdaptorWriteDeleteCallback<TFrom> writeDeleteValueCallback)
        {
            if (parent == null)
                throw new ArgumentNullException("parent");
            if (writeValueCallback == null)
                throw new ArgumentNullException("writeValueCallback");
            if (writeDeleteValueCallback == null)
                throw new ArgumentNullException("writeDeleteValueCallback");

            m_parent = parent;
            m_writeValueCallback = writeValueCallback;
            m_writeDeleteValueCallback = writeDeleteValueCallback;
            m_interval = new Lazy<CesiumWriterAdaptor<TFrom, TValue>>(() => new CesiumWriterAdaptor<TFrom, TValue>((TFrom)m_parent.IntervalWriter, m_writeValueCallback, m_writeDeleteValueCallback), false);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            m_parent.Close();
        }

        /// <summary>
        /// Gets the parent being adapted.
        /// </summary>
        public TFrom Parent
        {
            get { return m_parent; }
        }

        /// <inheritdoc />
        public bool IsOpen
        {
            get { return m_parent.IsOpen; }
        }

        /// <inheritdoc />
        public CesiumOutputStream Output
        {
            get { return m_parent.Output; }
        }

        /// <inheritdoc />
        public void WriteValue(TValue value)
        {
            m_writeValueCallback(m_parent, value);
        }

        /// <inheritdoc />
        public void WriteDelete(bool value)
        {
            m_writeDeleteValueCallback(m_parent);
        }

        /// <inheritdoc />
        public void WriteInterval(JulianDate start, JulianDate stop)
        {
            m_parent.WriteInterval(start, stop);
        }

        /// <inheritdoc />
        public ICesiumPropertyWriter OpenInterval()
        {
            m_interval.Value.Open(m_parent.Output);
            return m_interval.Value;
        }

        /// <inheritdoc />
        public ICesiumIntervalListWriter OpenMultipleIntervals()
        {
            return m_parent.OpenMultipleIntervals();
        }

        /// <inheritdoc />
        public ICesiumPropertyWriter IntervalWriter
        {
            get { return m_interval.Value; }
        }

        /// <inheritdoc />
        public bool ForceInterval
        {
            get { return m_parent.ForceInterval; }
            set { m_parent.ForceInterval = value; }
        }

        /// <inheritdoc />
        public void Open(CesiumOutputStream output)
        {
            m_parent.Open(output);
        }

        /// <inheritdoc />
        public void Close()
        {
            m_parent.Close();
        }

        [NotNull]
        private readonly TFrom m_parent;
        [NotNull]
        private readonly CesiumWriterAdaptorWriteCallback<TFrom, TValue> m_writeValueCallback;
        [NotNull]
        private readonly CesiumWriterAdaptorWriteDeleteCallback<TFrom> m_writeDeleteValueCallback;
        [NotNull]
        private readonly Lazy<CesiumWriterAdaptor<TFrom, TValue>> m_interval;
    }
}