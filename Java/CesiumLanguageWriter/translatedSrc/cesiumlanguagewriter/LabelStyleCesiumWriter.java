package cesiumlanguagewriter;


import agi.foundation.compatibility.*;
import agi.foundation.compatibility.Func1;
import agi.foundation.compatibility.Lazy;
import cesiumlanguagewriter.advanced.*;
import cesiumlanguagewriter.CesiumLabelStyle;
import cesiumlanguagewriter.Reference;
import javax.annotation.Nonnull;

/**
 *  
 Writes a {@code LabelStyle} to a {@link CesiumOutputStream}. A {@code LabelStyle} is the style of a label.
 

 */
@SuppressWarnings( {
        "unused",
        "deprecation",
        "serial"
})
public class LabelStyleCesiumWriter extends CesiumPropertyWriter<LabelStyleCesiumWriter> {
    /**
    *  
    The name of the {@code labelStyle} property.
    

    */
    public static final String LabelStylePropertyName = "labelStyle";
    /**
    *  
    The name of the {@code reference} property.
    

    */
    public static final String ReferencePropertyName = "reference";
    /**
    *  
    The name of the {@code delete} property.
    

    */
    public static final String DeletePropertyName = "delete";
    private Lazy<ICesiumValuePropertyWriter<CesiumLabelStyle>> m_asLabelStyle;
    private Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;

    /**
    *  
    Initializes a new instance.
    
    

    * @param propertyName The name of the property.
    */
    public LabelStyleCesiumWriter(@Nonnull String propertyName) {
        super(propertyName);
        m_asLabelStyle = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumLabelStyle>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumLabelStyle>>(
                this, "createLabelStyleAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumLabelStyle> invoke() {
                return createLabelStyleAdaptor();
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
    protected LabelStyleCesiumWriter(@Nonnull LabelStyleCesiumWriter existingInstance) {
        super(existingInstance);
        m_asLabelStyle = new Lazy<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumLabelStyle>>(new Func1<cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumLabelStyle>>(
                this, "createLabelStyleAdaptor") {
            public cesiumlanguagewriter.advanced.ICesiumValuePropertyWriter<CesiumLabelStyle> invoke() {
                return createLabelStyleAdaptor();
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
    public LabelStyleCesiumWriter clone() {
        return new LabelStyleCesiumWriter(this);
    }

    /**
    *  
    Writes the value expressed as a {@code labelStyle}, which is the label style.
    
    

    * @param value The label style.
    */
    public final void writeLabelStyle(@Nonnull CesiumLabelStyle value) {
        final String PropertyName = LabelStylePropertyName;
        if (getForceInterval()) {
            openIntervalIfNecessary();
        }
        if (getIsInterval()) {
            getOutput().writePropertyName(PropertyName);
        }
        getOutput().writeValue(CesiumFormattingHelper.labelStyleToString(value));
    }

    /**
    *  
    Writes the value expressed as a {@code reference}, which is the label style specified as a reference to another property.
    
    

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
    Writes the value expressed as a {@code reference}, which is the label style specified as a reference to another property.
    
    

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
    Writes the value expressed as a {@code reference}, which is the label style specified as a reference to another property.
    
    
    

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
    Writes the value expressed as a {@code reference}, which is the label style specified as a reference to another property.
    
    
    

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
    Writes the value expressed as a {@code delete}, which is whether the client should delete existing data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
    
    

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
    Returns a wrapper for this instance that implements {@link ICesiumValuePropertyWriter} to write a value in {@code LabelStyle} format. Because the returned instance is a wrapper for this instance, you may call {@link ICesiumElementWriter#close} on either this instance or the wrapper, but you must not call it on both.
    
    

    * @return The wrapper.
    */
    public final ICesiumValuePropertyWriter<CesiumLabelStyle> asLabelStyle() {
        return m_asLabelStyle.getValue();
    }

    private final ICesiumValuePropertyWriter<CesiumLabelStyle> createLabelStyleAdaptor() {
        return new CesiumWriterAdaptor<cesiumlanguagewriter.LabelStyleCesiumWriter, cesiumlanguagewriter.CesiumLabelStyle>(this,
                new CesiumWriterAdaptorWriteCallback<cesiumlanguagewriter.LabelStyleCesiumWriter, cesiumlanguagewriter.CesiumLabelStyle>() {
                    public void invoke(LabelStyleCesiumWriter me, @Nonnull CesiumLabelStyle value) {
                        me.writeLabelStyle(value);
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
        return new CesiumWriterAdaptor<cesiumlanguagewriter.LabelStyleCesiumWriter, cesiumlanguagewriter.Reference>(this,
                new CesiumWriterAdaptorWriteCallback<cesiumlanguagewriter.LabelStyleCesiumWriter, cesiumlanguagewriter.Reference>() {
                    public void invoke(LabelStyleCesiumWriter me, Reference value) {
                        me.writeReference(value);
                    }
                });
    }
}