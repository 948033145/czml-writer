package cesiumlanguagewriter;


import agi.foundation.compatibility.*;
import agi.foundation.compatibility.Func1;
import agi.foundation.compatibility.Lazy;
import cesiumlanguagewriter.advanced.*;
import cesiumlanguagewriter.Reference;
import cesiumlanguagewriter.UnitQuaternion;
import java.util.List;
import javax.annotation.Nonnull;

/**
 *  
 Writes a {@code Orientation} to a {@link CesiumOutputStream}. A {@code Orientation} is defines an orientation. An orientation is a rotation that takes a vector expressed in the "body" axes of the object and transforms it to the Earth fixed axes.
 

 */
@SuppressWarnings( {
        "unused",
        "deprecation",
        "serial"
})
public class OrientationCesiumWriter extends CesiumInterpolatablePropertyWriter<OrientationCesiumWriter> {
    /**
    *  
    The name of the {@code unitQuaternion} property.
    

    */
    public static final String UnitQuaternionPropertyName = "unitQuaternion";
    /**
    *  
    The name of the {@code reference} property.
    

    */
    public static final String ReferencePropertyName = "reference";
    /**
    *  
    The name of the {@code velocityReference} property.
    

    */
    public static final String VelocityReferencePropertyName = "velocityReference";
    /**
    *  
    The name of the {@code delete} property.
    

    */
    public static final String DeletePropertyName = "delete";
    private Lazy<ICesiumInterpolatableValuePropertyWriter<UnitQuaternion>> m_asUnitQuaternion;
    private Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;
    private Lazy<ICesiumValuePropertyWriter<Reference>> m_asVelocityReference;

    /**
    *  
    Initializes a new instance.
    
    

    * @param propertyName The name of the property.
    */
    public OrientationCesiumWriter(@Nonnull String propertyName) {
        super(propertyName);
        m_asUnitQuaternion = new Lazy<cesiumlanguagewriter.advanced.ICesiumInterpolatableValuePropertyWriter<UnitQuaternion>>(
                new Func1<cesiumlanguagewriter.advanced.ICesiumInterpolatableValuePropertyWriter<UnitQuaternion>>(this, "createUnitQuaternionAdaptor") {
                    public cesiumlanguagewriter.advanced.ICesiumInterpolatableValuePropertyWriter<UnitQuaternion> invoke() {
                        return createUnitQuaternionAdaptor();
                    }
                }, false);
        m_asReference = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(this,
                "createReferenceAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference> invoke() {
                return createReferenceAdaptor();
            }
        }, false);
        m_asVelocityReference = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(this,
                "createVelocityReferenceAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference> invoke() {
                return createVelocityReferenceAdaptor();
            }
        }, false);
    }

    /**
    *  
    Initializes a new instance as a copy of an existing instance.
    
    

    * @param existingInstance The existing instance to copy.
    */
    protected OrientationCesiumWriter(@Nonnull OrientationCesiumWriter existingInstance) {
        super(existingInstance);
        m_asUnitQuaternion = new Lazy<cesiumlanguagewriter.advanced.ICesiumInterpolatableValuePropertyWriter<UnitQuaternion>>(
                new Func1<cesiumlanguagewriter.advanced.ICesiumInterpolatableValuePropertyWriter<UnitQuaternion>>(this, "createUnitQuaternionAdaptor") {
                    public cesiumlanguagewriter.advanced.ICesiumInterpolatableValuePropertyWriter<UnitQuaternion> invoke() {
                        return createUnitQuaternionAdaptor();
                    }
                }, false);
        m_asReference = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(this,
                "createReferenceAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference> invoke() {
                return createReferenceAdaptor();
            }
        }, false);
        m_asVelocityReference = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(this,
                "createVelocityReferenceAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference> invoke() {
                return createVelocityReferenceAdaptor();
            }
        }, false);
    }

    /**
    *  
    
    Copies this instance and returns the copy.
    
    

    * @return The copy.
    */
    @Override
    public OrientationCesiumWriter clone() {
        return new OrientationCesiumWriter(this);
    }

    /**
    *  
    Writes the value expressed as a {@code unitQuaternion}, which is the orientation specified as a 4-dimensional unit magnitude quaternion, specified as {@code [X, Y, Z, W]}.
    
    

    * @param value The value.
    */
    public final void writeUnitQuaternion(@Nonnull UnitQuaternion value) {
        final String PropertyName = UnitQuaternionPropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeUnitQuaternion(getOutput(), value);
    }

    /**
    *  
    Writes the value expressed as a {@code unitQuaternion}, which is the orientation specified as a 4-dimensional unit magnitude quaternion, specified as {@code [X, Y, Z, W]}.
    
    
    

    * @param dates The dates at which the value is specified.
    * @param values The values corresponding to each date.
    */
    public final void writeUnitQuaternion(List<JulianDate> dates, List<UnitQuaternion> values) {
        writeUnitQuaternion(dates, values, 0, dates.size());
    }

    /**
    *  
    Writes the value expressed as a {@code unitQuaternion}, which is the orientation specified as a 4-dimensional unit magnitude quaternion, specified as {@code [X, Y, Z, W]}.
    
    
    
    
    

    * @param dates The dates at which the value is specified.
    * @param values The values corresponding to each date.
    * @param startIndex The index of the first element to write.
    * @param length The number of elements to write.
    */
    public final void writeUnitQuaternion(List<JulianDate> dates, List<UnitQuaternion> values, int startIndex, int length) {
        final String PropertyName = UnitQuaternionPropertyName;
        openIntervalIfNecessary();
        CesiumWritingHelper.writeUnitQuaternion(getOutput(), PropertyName, dates, values, startIndex, length);
    }

    /**
    *  
    Writes the value expressed as a {@code reference}, which is the orientation specified as a reference to another property.
    
    

    * @param value The reference.
    */
    public final void writeReference(Reference value) {
        final String PropertyName = ReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), value);
    }

    /**
    *  
    Writes the value expressed as a {@code reference}, which is the orientation specified as a reference to another property.
    
    

    * @param value The earliest date of the interval.
    */
    public final void writeReference(String value) {
        final String PropertyName = ReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), value);
    }

    /**
    *  
    Writes the value expressed as a {@code reference}, which is the orientation specified as a reference to another property.
    
    
    

    * @param identifier The identifier of the object which contains the referenced property.
    * @param propertyName The property on the referenced object.
    */
    public final void writeReference(String identifier, String propertyName) {
        final String PropertyName = ReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), identifier, propertyName);
    }

    /**
    *  
    Writes the value expressed as a {@code reference}, which is the orientation specified as a reference to another property.
    
    
    

    * @param identifier The identifier of the object which contains the referenced property.
    * @param propertyNames The hierarchy of properties to be indexed on the referenced object.
    */
    public final void writeReference(String identifier, String[] propertyNames) {
        final String PropertyName = ReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), identifier, propertyNames);
    }

    /**
    *  
    Writes the value expressed as a {@code velocityReference}, which is the orientation specified as the normalized velocity vector of a position property. The reference must be to a {@code position} property.
    
    

    * @param value The reference.
    */
    public final void writeVelocityReference(Reference value) {
        final String PropertyName = VelocityReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), value);
    }

    /**
    *  
    Writes the value expressed as a {@code velocityReference}, which is the orientation specified as the normalized velocity vector of a position property. The reference must be to a {@code position} property.
    
    

    * @param value The earliest date of the interval.
    */
    public final void writeVelocityReference(String value) {
        final String PropertyName = VelocityReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), value);
    }

    /**
    *  
    Writes the value expressed as a {@code velocityReference}, which is the orientation specified as the normalized velocity vector of a position property. The reference must be to a {@code position} property.
    
    
    

    * @param identifier The identifier of the object which contains the referenced property.
    * @param propertyName The property on the referenced object.
    */
    public final void writeVelocityReference(String identifier, String propertyName) {
        final String PropertyName = VelocityReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), identifier, propertyName);
    }

    /**
    *  
    Writes the value expressed as a {@code velocityReference}, which is the orientation specified as the normalized velocity vector of a position property. The reference must be to a {@code position} property.
    
    
    

    * @param identifier The identifier of the object which contains the referenced property.
    * @param propertyNames The hierarchy of properties to be indexed on the referenced object.
    */
    public final void writeVelocityReference(String identifier, String[] propertyNames) {
        final String PropertyName = VelocityReferencePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        CesiumWritingHelper.writeReference(getOutput(), identifier, propertyNames);
    }

    /**
    *  
    Writes the value expressed as a {@code delete}, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
    
    

    * @param value The value.
    */
    public final void writeDelete(boolean value) {
        final String PropertyName = DeletePropertyName;
        openIntervalIfNecessary();
        getOutput().writePropertyName(PropertyName);
        getOutput().writeValue(value);
    }

    /**
    *  
    Returns a wrapper for this instance that implements {@link ICesiumInterpolatableValuePropertyWriter} to write a value in {@code UnitQuaternion} format. Because the returned instance is a wrapper for this instance, you may call {@link ICesiumElementWriter#close} on either this instance or the wrapper, but you must not call it on both.
    
    

    * @return The wrapper.
    */
    public final ICesiumInterpolatableValuePropertyWriter<UnitQuaternion> asUnitQuaternion() {
        return m_asUnitQuaternion.getValue();
    }

    private final ICesiumInterpolatableValuePropertyWriter<UnitQuaternion> createUnitQuaternionAdaptor() {
        return new CesiumInterpolatableWriterAdaptor<cesiumlanguagewriter.OrientationCesiumWriter, cesiumlanguagewriter.UnitQuaternion>(this,
                new CesiumWriterAdaptorWriteCallback<cesiumlanguagewriter.OrientationCesiumWriter, cesiumlanguagewriter.UnitQuaternion>() {
                    public void invoke(OrientationCesiumWriter me, UnitQuaternion value) {
                        me.writeUnitQuaternion(value);
                    }
                }, new CesiumWriterAdaptorWriteSamplesCallback<cesiumlanguagewriter.OrientationCesiumWriter, cesiumlanguagewriter.UnitQuaternion>() {
                    public void invoke(OrientationCesiumWriter me, List<JulianDate> dates, List<UnitQuaternion> values, int startIndex, int length) {
                        me.writeUnitQuaternion(dates, values, startIndex, length);
                    }
                });
    }

    /**
    *  
    Returns a wrapper for this instance that implements {@link ICesiumValuePropertyWriter} to write a value in {@code Reference} format. Because the returned instance is a wrapper for this instance, you may call {@link ICesiumElementWriter#close} on either this instance or the wrapper, but you must not call it on both.
    
    

    * @return The wrapper.
    */
    public final ICesiumValuePropertyWriter<Reference> asReference() {
        return m_asReference.getValue();
    }

    private final ICesiumValuePropertyWriter<Reference> createReferenceAdaptor() {
        return new CesiumWriterAdaptor<cesiumlanguagewriter.OrientationCesiumWriter, cesiumlanguagewriter.Reference>(this,
                new CesiumWriterAdaptorWriteCallback<cesiumlanguagewriter.OrientationCesiumWriter, cesiumlanguagewriter.Reference>() {
                    public void invoke(OrientationCesiumWriter me, Reference value) {
                        me.writeReference(value);
                    }
                });
    }

    /**
    *  
    Returns a wrapper for this instance that implements {@link ICesiumValuePropertyWriter} to write a value in {@code VelocityReference} format. Because the returned instance is a wrapper for this instance, you may call {@link ICesiumElementWriter#close} on either this instance or the wrapper, but you must not call it on both.
    
    

    * @return The wrapper.
    */
    public final ICesiumValuePropertyWriter<Reference> asVelocityReference() {
        return m_asVelocityReference.getValue();
    }

    private final ICesiumValuePropertyWriter<Reference> createVelocityReferenceAdaptor() {
        return new CesiumWriterAdaptor<cesiumlanguagewriter.OrientationCesiumWriter, cesiumlanguagewriter.Reference>(this,
                new CesiumWriterAdaptorWriteCallback<cesiumlanguagewriter.OrientationCesiumWriter, cesiumlanguagewriter.Reference>() {
                    public void invoke(OrientationCesiumWriter me, Reference value) {
                        me.writeVelocityReference(value);
                    }
                });
    }
}