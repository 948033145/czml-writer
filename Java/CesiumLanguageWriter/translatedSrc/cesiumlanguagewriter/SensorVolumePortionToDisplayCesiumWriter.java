package cesiumlanguagewriter;


import agi.foundation.compatibility.*;
import agi.foundation.compatibility.Func1;
import agi.foundation.compatibility.Lazy;
import cesiumlanguagewriter.advanced.*;
import cesiumlanguagewriter.CesiumSensorVolumePortionToDisplay;
import cesiumlanguagewriter.Reference;
import javax.annotation.Nonnull;

/**
 *  
 Writes a {@code SensorVolumePortionToDisplay} to a {@link CesiumOutputStream}. A {@code SensorVolumePortionToDisplay} is what part of a sensor should be displayed.
 

 */
@SuppressWarnings( {
        "unused",
        "deprecation",
        "serial"
})
public class SensorVolumePortionToDisplayCesiumWriter extends CesiumPropertyWriter<SensorVolumePortionToDisplayCesiumWriter> {
    /**
    *  
    The name of the {@code portionToDisplay} property.
    

    */
    public static final String PortionToDisplayPropertyName = "portionToDisplay";
    /**
    *  
    The name of the {@code reference} property.
    

    */
    public static final String ReferencePropertyName = "reference";
    private Lazy<ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay>> m_asPortionToDisplay;
    private Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;

    /**
    *  
    Initializes a new instance.
    
    

    * @param propertyName The name of the property.
    */
    public SensorVolumePortionToDisplayCesiumWriter(@Nonnull String propertyName) {
        super(propertyName);
        m_asPortionToDisplay = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay>>(
                new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay>>(this, "createPortionToDisplayAdaptor") {
                    public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay> invoke() {
                        return createPortionToDisplayAdaptor();
                    }
                }, false);
        m_asReference = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(this,
                "createReferenceAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference> invoke() {
                return createReferenceAdaptor();
            }
        }, false);
    }

    /**
    *  
    Initializes a new instance as a copy of an existing instance.
    
    

    * @param existingInstance The existing instance to copy.
    */
    protected SensorVolumePortionToDisplayCesiumWriter(@Nonnull SensorVolumePortionToDisplayCesiumWriter existingInstance) {
        super(existingInstance);
        m_asPortionToDisplay = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay>>(
                new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay>>(this, "createPortionToDisplayAdaptor") {
                    public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay> invoke() {
                        return createPortionToDisplayAdaptor();
                    }
                }, false);
        m_asReference = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference>>(this,
                "createReferenceAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<Reference> invoke() {
                return createReferenceAdaptor();
            }
        }, false);
    }

    /**
    *  
    
    Copies this instance and returns the copy.
    
    

    * @return The copy.
    */
    @Override
    public SensorVolumePortionToDisplayCesiumWriter clone() {
        return new SensorVolumePortionToDisplayCesiumWriter(this);
    }

    /**
    *  
    Writes the value expressed as a {@code portionToDisplay}, which is the part of a sensor to display.
    
    

    * @param value The portion of the sensor to display.
    */
    public final void writePortionToDisplay(@Nonnull CesiumSensorVolumePortionToDisplay value) {
        final String PropertyName = PortionToDisplayPropertyName;
        if (getForceInterval()) {
            openIntervalIfNecessary();
        }
        if (getIsInterval()) {
            getOutput().writePropertyName(PropertyName);
        }
        getOutput().writeValue(CesiumFormattingHelper.sensorVolumePortionToDisplayToString(value));
    }

    /**
    *  
    Writes the value expressed as a {@code reference}, which is the part of a sensor to display, specified as a reference to another property.
    
    

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
    Writes the value expressed as a {@code reference}, which is the part of a sensor to display, specified as a reference to another property.
    
    

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
    Writes the value expressed as a {@code reference}, which is the part of a sensor to display, specified as a reference to another property.
    
    
    

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
    Writes the value expressed as a {@code reference}, which is the part of a sensor to display, specified as a reference to another property.
    
    
    

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
    Returns a wrapper for this instance that implements {@link ICesiumValuePropertyWriter} to write a value in {@code PortionToDisplay} format. Because the returned instance is a wrapper for this instance, you may call {@link ICesiumElementWriter#close} on either this instance or the wrapper, but you must not call it on both.
    
    

    * @return The wrapper.
    */
    public final ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay> asPortionToDisplay() {
        return m_asPortionToDisplay.getValue();
    }

    private final ICesiumValuePropertyWriter<CesiumSensorVolumePortionToDisplay> createPortionToDisplayAdaptor() {
        return new CesiumWriterAdaptor<cesiumlanguagewriter.SensorVolumePortionToDisplayCesiumWriter, cesiumlanguagewriter.CesiumSensorVolumePortionToDisplay>(this,
                new CesiumWriterAdaptorWriteCallback<cesiumlanguagewriter.SensorVolumePortionToDisplayCesiumWriter, cesiumlanguagewriter.CesiumSensorVolumePortionToDisplay>() {
                    public void invoke(SensorVolumePortionToDisplayCesiumWriter me, @Nonnull CesiumSensorVolumePortionToDisplay value) {
                        me.writePortionToDisplay(value);
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
        return new CesiumWriterAdaptor<cesiumlanguagewriter.SensorVolumePortionToDisplayCesiumWriter, cesiumlanguagewriter.Reference>(this,
                new CesiumWriterAdaptorWriteCallback<cesiumlanguagewriter.SensorVolumePortionToDisplayCesiumWriter, cesiumlanguagewriter.Reference>() {
                    public void invoke(SensorVolumePortionToDisplayCesiumWriter me, Reference value) {
                        me.writeReference(value);
                    }
                });
    }
}