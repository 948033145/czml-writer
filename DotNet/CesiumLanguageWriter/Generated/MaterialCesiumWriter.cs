﻿// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Material</c> to a <see cref="CesiumOutputStream"/>. A <c>Material</c> is a definition of how a surface is colored or shaded.
    /// </summary>
    public class MaterialCesiumWriter : CesiumPropertyWriter<MaterialCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>solidColor</c> property.
        /// </summary>
        public const string SolidColorPropertyName = "solidColor";

        /// <summary>
        /// The name of the <c>image</c> property.
        /// </summary>
        public const string ImagePropertyName = "image";

        /// <summary>
        /// The name of the <c>grid</c> property.
        /// </summary>
        public const string GridPropertyName = "grid";

        /// <summary>
        /// The name of the <c>stripe</c> property.
        /// </summary>
        public const string StripePropertyName = "stripe";

        /// <summary>
        /// The name of the <c>checkerboard</c> property.
        /// </summary>
        public const string CheckerboardPropertyName = "checkerboard";

        private readonly Lazy<SolidColorMaterialCesiumWriter> m_solidColor = new Lazy<SolidColorMaterialCesiumWriter>(() => new SolidColorMaterialCesiumWriter(SolidColorPropertyName), false);
        private readonly Lazy<ImageMaterialCesiumWriter> m_image = new Lazy<ImageMaterialCesiumWriter>(() => new ImageMaterialCesiumWriter(ImagePropertyName), false);
        private readonly Lazy<GridMaterialCesiumWriter> m_grid = new Lazy<GridMaterialCesiumWriter>(() => new GridMaterialCesiumWriter(GridPropertyName), false);
        private readonly Lazy<StripeMaterialCesiumWriter> m_stripe = new Lazy<StripeMaterialCesiumWriter>(() => new StripeMaterialCesiumWriter(StripePropertyName), false);
        private readonly Lazy<CheckerboardMaterialCesiumWriter> m_checkerboard = new Lazy<CheckerboardMaterialCesiumWriter>(() => new CheckerboardMaterialCesiumWriter(CheckerboardPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public MaterialCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected MaterialCesiumWriter([NotNull] MaterialCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc/>
        public override MaterialCesiumWriter Clone()
        {
            return new MaterialCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>solidColor</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>solidColor</c> property defines a material that fills the surface with a solid color, which may be translucent.
        /// </summary>
        [NotNull]
        public SolidColorMaterialCesiumWriter SolidColorWriter
        {
            get { return m_solidColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>solidColor</c> property. The <c>solidColor</c> property defines a material that fills the surface with a solid color, which may be translucent.
        /// </summary>
        [NotNull]
        public SolidColorMaterialCesiumWriter OpenSolidColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(SolidColorWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>image</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>image</c> property defines a material that fills the surface with an image.
        /// </summary>
        [NotNull]
        public ImageMaterialCesiumWriter ImageWriter
        {
            get { return m_image.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>image</c> property. The <c>image</c> property defines a material that fills the surface with an image.
        /// </summary>
        [NotNull]
        public ImageMaterialCesiumWriter OpenImageProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ImageWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>grid</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>grid</c> property defines a material that fills the surface with a grid.
        /// </summary>
        [NotNull]
        public GridMaterialCesiumWriter GridWriter
        {
            get { return m_grid.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>grid</c> property. The <c>grid</c> property defines a material that fills the surface with a grid.
        /// </summary>
        [NotNull]
        public GridMaterialCesiumWriter OpenGridProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(GridWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>stripe</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>stripe</c> property defines a material that fills the surface with alternating colors.
        /// </summary>
        [NotNull]
        public StripeMaterialCesiumWriter StripeWriter
        {
            get { return m_stripe.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>stripe</c> property. The <c>stripe</c> property defines a material that fills the surface with alternating colors.
        /// </summary>
        [NotNull]
        public StripeMaterialCesiumWriter OpenStripeProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(StripeWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>checkerboard</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>checkerboard</c> property defines a material that fills the surface with a checkerboard pattern.
        /// </summary>
        [NotNull]
        public CheckerboardMaterialCesiumWriter CheckerboardWriter
        {
            get { return m_checkerboard.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>checkerboard</c> property. The <c>checkerboard</c> property defines a material that fills the surface with a checkerboard pattern.
        /// </summary>
        [NotNull]
        public CheckerboardMaterialCesiumWriter OpenCheckerboardProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(CheckerboardWriter);
        }

    }
}
