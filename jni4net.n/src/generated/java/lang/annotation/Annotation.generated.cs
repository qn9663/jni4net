//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.annotation {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Annotation {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int hashCode();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool equals(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String toString();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        global::java.lang.Class annotationType();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Annotation_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::java.lang.annotation.@__Annotation.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.annotation.Annotation))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.annotation.Annotation))]
    internal sealed partial class @__Annotation : global::java.lang.Object, global::java.lang.annotation.Annotation {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode0;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals1;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString2;
        
        internal static global::net.sf.jni4net.jni.MethodId _annotationType3;
        
        private @__Annotation(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.annotation.@__Annotation.staticClass = @__class;
            global::java.lang.annotation.@__Annotation._hashCode0 = @__env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "hashCode", "()I");
            global::java.lang.annotation.@__Annotation._equals1 = @__env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.lang.annotation.@__Annotation._toString2 = @__env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.annotation.@__Annotation._annotationType3 = @__env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "annotationType", "()Ljava/lang/Class;");
        }
        
        public int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.annotation.@__Annotation._hashCode0)));
        }
        
        public bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.annotation.@__Annotation._equals1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        public global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.annotation.@__Annotation._toString2));
        }
        
        public global::java.lang.Class annotationType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.annotation.@__Annotation._annotationType3));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Annotation);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "hashCode", "hashCode0", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "equals", "equals1", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "toString", "toString2", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "annotationType", "annotationType3", "()Ljava/lang/Class;"));
            return methods;
        }
        
        private static int hashCode0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.annotation.Annotation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.annotation.Annotation>(@__env, @__obj);
            return ((int)(@__real.hashCode()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(int);
        }
        
        private static bool equals1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.annotation.Annotation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.annotation.Annotation>(@__env, @__obj);
            return ((bool)(@__real.equals(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle toString2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.annotation.Annotation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.annotation.Annotation>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.toString());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle annotationType3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/Class;
            // ()Ljava/lang/Class;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.annotation.Annotation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.annotation.Annotation>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.annotationType());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.annotation.@__Annotation(@__env);
            }
        }
    }
    #endregion
}
