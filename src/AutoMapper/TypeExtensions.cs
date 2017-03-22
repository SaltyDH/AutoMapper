using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper.Internal;

namespace AutoMapper
{
#if NET45
    using System.Reflection.Emit;
#endif

    internal static class TypeExtensions
    {
        public static bool Has<TAttribute>(this Type type) where TAttribute : Attribute => TypeHelper.Has<TAttribute>(type);

        public static Type GetGenericTypeDefinitionIfGeneric(this Type type) => TypeHelper.GetGenericTypeDefinitionIfGeneric(type);

        public static Type[] GetGenericArguments(this Type type) => TypeHelper.GetGenericArguments(type);

        public static Type[] GetGenericParameters(this Type type) => TypeHelper.GetGenericParameters(type);

        public static IEnumerable<ConstructorInfo> GetDeclaredConstructors(this Type type) => TypeHelper.GetDeclaredConstructors(type);

#if NET45
        public static Type CreateType(this TypeBuilder type)
        {
            return TypeHelper.CreateType(type);
        }
#endif

        public static IEnumerable<MemberInfo> GetDeclaredMembers(this Type type) => TypeHelper.GetDeclaredMembers(type);

        public static IEnumerable<MemberInfo> GetAllMembers(this Type type) => TypeHelper.GetAllMembers(type);

        public static MemberInfo[] GetMember(this Type type, string name) => TypeHelper.GetMember(type, name);

        public static IEnumerable<MethodInfo> GetDeclaredMethods(this Type type) => TypeHelper.GetDeclaredMethods(type);

        public static MethodInfo GetDeclaredMethod(this Type type, string name) => TypeHelper.GetDeclaredMethod(type, name);

        public static MethodInfo GetDeclaredMethod(this Type type, string name, Type[] parameters) => TypeHelper.GetDeclaredMethod(type, name, parameters);

        public static ConstructorInfo GetDeclaredConstructor(this Type type, Type[] parameters) => TypeHelper.GetDeclaredConstructor(type, parameters);

        public static IEnumerable<MethodInfo> GetAllMethods(this Type type) => TypeHelper.GetAllMethods(type);

        public static IEnumerable<PropertyInfo> GetDeclaredProperties(this Type type) => TypeHelper.GetDeclaredProperties(type);

        public static PropertyInfo GetDeclaredProperty(this Type type, string name)
            => TypeHelper.GetDeclaredProperty(type, name);

        public static object[] GetCustomAttributes(this Type type, Type attributeType, bool inherit)
            => TypeHelper.GetCustomAttributes(type, attributeType, inherit);

        public static bool IsStatic(this FieldInfo fieldInfo) => TypeHelper.IsStatic(fieldInfo);

        public static bool IsStatic(this PropertyInfo propertyInfo) => TypeHelper.IsStatic(propertyInfo);

        public static bool IsStatic(this MemberInfo memberInfo) => TypeHelper.IsStatic(memberInfo);

        public static bool IsPublic(this PropertyInfo propertyInfo) => TypeHelper.IsPublic(propertyInfo);

        public static IEnumerable<PropertyInfo> PropertiesWithAnInaccessibleSetter(this Type type)
            => TypeHelper.PropertiesWithAnInaccessibleSetter(type);

        public static bool HasAnInaccessibleSetter(this PropertyInfo property) 
            => TypeHelper.HasAnInaccessibleSetter(property);

        public static bool IsPublic(this MemberInfo memberInfo) => TypeHelper.IsPublic(memberInfo);

        public static bool IsNotPublic(this ConstructorInfo constructorInfo) => TypeHelper.IsNotPublic(constructorInfo);

        public static Assembly Assembly(this Type type) => TypeHelper.Assembly(type);

        public static Type BaseType(this Type type) => TypeHelper.BaseType(type);

        public static bool IsAssignableFrom(this Type type, Type other)
            => TypeHelper.IsAssignableFrom(type, other);

        public static bool IsAbstract(this Type type) => TypeHelper.IsAbstract(type);

        public static bool IsClass(this Type type) => TypeHelper.IsClass(type);

        public static bool IsEnum(this Type type) => TypeHelper.IsEnum(type);

        public static bool IsGenericType(this Type type) => TypeHelper.IsGenericType(type);

        public static bool IsGenericTypeDefinition(this Type type) => TypeHelper.IsGenericTypeDefinition(type);

        public static bool IsInterface(this Type type) => TypeHelper.IsInterface(type);

        public static bool IsPrimitive(this Type type) => TypeHelper.IsPrimitive(type);

        public static bool IsSealed(this Type type) => TypeHelper.IsSealed(type);

        public static bool IsValueType(this Type type) => TypeHelper.IsValueType(type);

        public static bool IsInstanceOfType(this Type type, object o) => TypeHelper.IsInstanceOfType(type, o);

        public static ConstructorInfo[] GetConstructors(this Type type) => TypeHelper.GetConstructors(type);

        public static PropertyInfo[] GetProperties(this Type type) => TypeHelper.GetProperties(type);

        public static MethodInfo GetGetMethod(this PropertyInfo propertyInfo, bool ignored) 
            => TypeHelper.GetGetMethod(propertyInfo, ignored);

        public static MethodInfo GetSetMethod(this PropertyInfo propertyInfo, bool ignored)
            => TypeHelper.GetSetMethod(propertyInfo, ignored);

        public static FieldInfo GetField(this Type type, string name) => TypeHelper.GetField(type, name);
    }
}
