﻿// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>DirectionList</c> to a <see cref="CesiumOutputStream"/>. A <c>DirectionList</c> is a list of directions.
    /// </summary>
    public class DirectionListCesiumWriter : CesiumPropertyWriter<DirectionListCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumSphericalListValuePropertyWriter, ICesiumUnitSphericalListValuePropertyWriter, ICesiumCartesian3ListValuePropertyWriter, ICesiumUnitCartesian3ListValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>spherical</c> property.
        /// </summary>
        public const string SphericalPropertyName = "spherical";

        /// <summary>
        /// The name of the <c>unitSpherical</c> property.
        /// </summary>
        public const string UnitSphericalPropertyName = "unitSpherical";

        /// <summary>
        /// The name of the <c>cartesian</c> property.
        /// </summary>
        public const string CartesianPropertyName = "cartesian";

        /// <summary>
        /// The name of the <c>unitCartesian</c> property.
        /// </summary>
        public const string UnitCartesianPropertyName = "unitCartesian";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumSphericalListValuePropertyAdaptor<DirectionListCesiumWriter>> m_asSpherical;
        private readonly Lazy<CesiumUnitSphericalListValuePropertyAdaptor<DirectionListCesiumWriter>> m_asUnitSpherical;
        private readonly Lazy<CesiumCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter>> m_asCartesian;
        private readonly Lazy<CesiumUnitCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter>> m_asUnitCartesian;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public DirectionListCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asSpherical = CreateAsSpherical();
            m_asUnitSpherical = CreateAsUnitSpherical();
            m_asCartesian = CreateAsCartesian();
            m_asUnitCartesian = CreateAsUnitCartesian();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected DirectionListCesiumWriter([NotNull] DirectionListCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asSpherical = CreateAsSpherical();
            m_asUnitSpherical = CreateAsUnitSpherical();
            m_asCartesian = CreateAsCartesian();
            m_asUnitCartesian = CreateAsUnitCartesian();
        }

        /// <inheritdoc/>
        public override DirectionListCesiumWriter Clone()
        {
            return new DirectionListCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>spherical</c>, which is the list of directions specified as spherical values <c>[Clock, Cone, Magnitude, Clock, Cone, Magnitude, ...]</c>, with angles in radians and magnitude in meters. The clock angle is measured in the XY plane from the positive X axis toward the positive Y axis. The cone angle is the angle from the positive Z axis toward the negative Z axis.
        /// </summary>
        /// <param name="values">The values.</param>
        public void WriteSpherical(IEnumerable<Spherical> values)
        {
            const string PropertyName = SphericalPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteSphericalList(Output, values);
        }

        /// <summary>
        /// Writes the value expressed as a <c>unitSpherical</c>, which is the list of directions specified as unit spherical values <c>[Clock, Cone, Clock, Cone, ...]</c>, in radians. The clock angle is measured in the XY plane from the positive X axis toward the positive Y axis. The cone angle is the angle from the positive Z axis toward the negative Z axis.
        /// </summary>
        /// <param name="values">The values.</param>
        public void WriteUnitSpherical(IEnumerable<UnitSpherical> values)
        {
            const string PropertyName = UnitSphericalPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteUnitSphericalList(Output, values);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian</c>, which is the list of directions specified as three-dimensional Cartesian values <c>[X, Y, Z, X, Y, Z, ...]</c>, in world coordinates in meters.
        /// </summary>
        /// <param name="values">The values.</param>
        public void WriteCartesian(IEnumerable<Cartesian> values)
        {
            const string PropertyName = CartesianPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteCartesian3List(Output, values);
        }

        /// <summary>
        /// Writes the value expressed as a <c>unitCartesian</c>, which is the list of directions specified as three-dimensional unit magnitude Cartesian values, <c>[X, Y, Z, X, Y, Z, ...]</c>, in world coordinates in meters.
        /// </summary>
        /// <param name="values">The values.</param>
        public void WriteUnitCartesian(IEnumerable<UnitCartesian> values)
        {
            const string PropertyName = UnitCartesianPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteUnitCartesian3List(Output, values);
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
        /// Returns a wrapper for this instance that implements <see cref="ICesiumSphericalListValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumSphericalListValuePropertyAdaptor<DirectionListCesiumWriter> AsSpherical()
        {
            return m_asSpherical.Value;
        }

        private Lazy<CesiumSphericalListValuePropertyAdaptor<DirectionListCesiumWriter>> CreateAsSpherical()
        {
            return new Lazy<CesiumSphericalListValuePropertyAdaptor<DirectionListCesiumWriter>>(CreateSphericalList, false);
        }

        private CesiumSphericalListValuePropertyAdaptor<DirectionListCesiumWriter> CreateSphericalList()
        {
            return CesiumValuePropertyAdaptors.CreateSphericalList(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumUnitSphericalListValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumUnitSphericalListValuePropertyAdaptor<DirectionListCesiumWriter> AsUnitSpherical()
        {
            return m_asUnitSpherical.Value;
        }

        private Lazy<CesiumUnitSphericalListValuePropertyAdaptor<DirectionListCesiumWriter>> CreateAsUnitSpherical()
        {
            return new Lazy<CesiumUnitSphericalListValuePropertyAdaptor<DirectionListCesiumWriter>>(CreateUnitSphericalList, false);
        }

        private CesiumUnitSphericalListValuePropertyAdaptor<DirectionListCesiumWriter> CreateUnitSphericalList()
        {
            return CesiumValuePropertyAdaptors.CreateUnitSphericalList(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumCartesian3ListValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter> AsCartesian()
        {
            return m_asCartesian.Value;
        }

        private Lazy<CesiumCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter>> CreateAsCartesian()
        {
            return new Lazy<CesiumCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter>>(CreateCartesian3List, false);
        }

        private CesiumCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter> CreateCartesian3List()
        {
            return CesiumValuePropertyAdaptors.CreateCartesian3List(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumUnitCartesian3ListValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumUnitCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter> AsUnitCartesian()
        {
            return m_asUnitCartesian.Value;
        }

        private Lazy<CesiumUnitCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter>> CreateAsUnitCartesian()
        {
            return new Lazy<CesiumUnitCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter>>(CreateUnitCartesian3List, false);
        }

        private CesiumUnitCartesian3ListValuePropertyAdaptor<DirectionListCesiumWriter> CreateUnitCartesian3List()
        {
            return CesiumValuePropertyAdaptors.CreateUnitCartesian3List(this);
        }

    }
}
