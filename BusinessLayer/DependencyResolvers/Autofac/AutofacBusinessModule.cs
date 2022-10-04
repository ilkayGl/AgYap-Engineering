using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<EfAboutDal>().As<IAboutDal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();

            builder.RegisterType<ContactLocationManager>().As<IContactLocationService>().SingleInstance();
            builder.RegisterType<EfContactLocationDal>().As<IContactLocationDal>().SingleInstance();

            builder.RegisterType<MyProjectManager>().As<IMyProjectService>().SingleInstance();
            builder.RegisterType<EfMyProjectDal>().As<IMyProjectDal>().SingleInstance();

            builder.RegisterType<UserAdminManager>().As<IUserAdminService>().SingleInstance();
            builder.RegisterType<EfUserAdminDal>().As<IUserAdminDal>().SingleInstance();
        }
    }
}
