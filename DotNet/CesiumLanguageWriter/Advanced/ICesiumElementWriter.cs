﻿using System;
using JetBrains.Annotations;

namespace CesiumLanguageWriter.Advanced
{
    /// <summary>
    /// An interface to an instance that can write elements of CZML.
    /// </summary>
    public interface ICesiumElementWriter : IDisposable
    {
        /// <summary>
        /// Gets a value indicating whether the writer is open.
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// Gets the <see cref="CesiumOutputStream"/> on which this writer is currently open.  If the writer is
        /// not open, accessing this property will throw an exception.
        /// </summary>
        /// <exception cref="InvalidOperationException">The writer is not currently open on a stream.</exception>
        [NotNull]
        CesiumOutputStream Output { get; }

        /// <summary>
        /// Opens this writer on a given <see cref="CesiumOutputStream"/>.  A single writer can write to multiple
        /// streams over its lifetime.  Opening a writer on a stream may cause data to be written to the stream.
        /// </summary>
        /// <param name="output">The stream to which to write.</param>
        /// <exception cref="InvalidOperationException">The writer is already open on a stream.</exception>
        void Open([NotNull] CesiumOutputStream output);

        /// <summary>
        /// Closes this writer on a given stream, but does not close the underlying stream.  Closing a writer
        /// on a stream may cause data to be written to the stream.
        /// </summary>
        /// <exception cref="InvalidOperationException">The writer is not open on a stream.</exception>
        void Close();
    }
}