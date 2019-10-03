﻿// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>SensorVolumePortionToDisplay</c> to a <see cref="CesiumOutputStream"/>. A <c>SensorVolumePortionToDisplay</c> is the part of a sensor that should be displayed.
    /// </summary>
    public class SensorVolumePortionToDisplayCesiumWriter : CesiumPropertyWriter<SensorVolumePortionToDisplayCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumSensorVolumePortionToDisplayValuePropertyWriter, ICesiumReferenceValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>portionToDisplay</c> property.
        /// </summary>
        public const string PortionToDisplayPropertyName = "portionToDisplay";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumSensorVolumePortionToDisplayValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter>> m_asPortionToDisplay;
        private readonly Lazy<CesiumReferenceValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public SensorVolumePortionToDisplayCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asPortionToDisplay = CreateAsPortionToDisplay();
            m_asReference = CreateAsReference();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected SensorVolumePortionToDisplayCesiumWriter([NotNull] SensorVolumePortionToDisplayCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asPortionToDisplay = CreateAsPortionToDisplay();
            m_asReference = CreateAsReference();
        }

        /// <inheritdoc/>
        public override SensorVolumePortionToDisplayCesiumWriter Clone()
        {
            return new SensorVolumePortionToDisplayCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>portionToDisplay</c>, which is the part of a sensor to display.
        /// </summary>
        /// <param name="value">The portion of the sensor to display.</param>
        public void WritePortionToDisplay(CesiumSensorVolumePortionToDisplay value)
        {
            const string PropertyName = PortionToDisplayPropertyName;
            if (ForceInterval)
            {
                OpenIntervalIfNecessary();
            }
            if (IsInterval)
            {
                Output.WritePropertyName(PropertyName);
            }
            Output.WriteValue(CesiumFormattingHelper.SensorVolumePortionToDisplayToString(value));
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the part of a sensor to display, specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the part of a sensor to display, specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the part of a sensor to display, specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the part of a sensor to display, specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Writes the value expressed as a <c>delete</c>, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDelete(bool value)
        {
            const string PropertyName = DeletePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumSensorVolumePortionToDisplayValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumSensorVolumePortionToDisplayValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter> AsPortionToDisplay()
        {
            return m_asPortionToDisplay.Value;
        }

        private Lazy<CesiumSensorVolumePortionToDisplayValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter>> CreateAsPortionToDisplay()
        {
            return new Lazy<CesiumSensorVolumePortionToDisplayValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter>>(CreateSensorVolumePortionToDisplay, false);
        }

        private CesiumSensorVolumePortionToDisplayValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter> CreateSensorVolumePortionToDisplay()
        {
            return CesiumValuePropertyAdaptors.CreateSensorVolumePortionToDisplay(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumReferenceValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumReferenceValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter> AsReference()
        {
            return m_asReference.Value;
        }

        private Lazy<CesiumReferenceValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter>> CreateAsReference()
        {
            return new Lazy<CesiumReferenceValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter>>(CreateReference, false);
        }

        private CesiumReferenceValuePropertyAdaptor<SensorVolumePortionToDisplayCesiumWriter> CreateReference()
        {
            return CesiumValuePropertyAdaptors.CreateReference(this);
        }

    }
}
