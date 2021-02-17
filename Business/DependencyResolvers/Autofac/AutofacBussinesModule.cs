﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    //WebApı kendi IoC altyapını kullanma autofac i kullan bağımlılığı azaltmak ve kendimizi tekrar etmemek için bu yapıyı kurduk.
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); //SingleInstance tek bir instance oluştur verinin kendisini tutmuyor herkes onu kullanıyor
                                                                                           //(100 bin kere veri tutmuyor aynı instance 100bin kişiye dağıtıyor)
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}