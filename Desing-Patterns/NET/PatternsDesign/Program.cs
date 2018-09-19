using PatternsDesign.Behavioral.command;
using PatternsDesign.Behavioral.memento;
using PatternsDesign.Behavioral.observer;
using PatternsDesign.Creational.abstract_factory;
using PatternsDesign.Creational.builder;
using PatternsDesign.Creational.factory;
using PatternsDesign.singleton;
using PatternsDesign.strategy;
using PatternsDesign.Structural;
using PatternsDesign.Structural.DAO;
using PatternsDesign.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign
{
    class Program
    {

        static void Main(string[] args)
        {
            #region  Behavioral Strategy
            //MainStrategy mainStrategy = new MainStrategy();
            #endregion

            #region  Creational Singleton
            /*SingletonInstancia.GetInstancia();

            SingletonInstancia.GetInstancia();*/
            #endregion

            #region  Creational factory- abstract factory
            /*var factoryAbstract = new Abstract_Factory();
            var instanciaBD = factoryAbstract.GetConexion(FactorysTypes.BD);
            var instanciaSERVICIOS = factoryAbstract.GetConexion(FactorysTypes.SERVICIOS);
            //Factory factory = new Factory();
            instanciaBD.GetBD(Conexiones.SQL).conectar();
            instanciaBD.GetBD(Conexiones.Mongo).conectar();

            instanciaSERVICIOS.GetREST(TiposServicios.REST).Leer();
            instanciaSERVICIOS.GetREST(TiposServicios.SOAP).Leer();*/
            #endregion

            #region  Structural Decorator
            /*ICarro Carro = new CarroLujo();
 
            CarroDecorator decorator = new AccesoriosAvanzados(Carro);

            Console.WriteLine(decorator.GetDescription());
            Console.WriteLine(decorator.GetCost());*/
            #endregion

            #region  Structural Command
            //ProxyAPI proxyAPI = new ProxyAPI();
            //Console.WriteLine(proxyAPI.GetPrecioDolar());
            #endregion

            #region Behavioral Command con Memento
            /*
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            Cuenta cuenta = new Cuenta(50896, 50000,ref originator,ref careTaker);
            
            Depositar depositar = new Depositar(cuenta, 5000);
            
            Retirar retirar = new Retirar(cuenta, 2500);
            
            Invocar invocar = new Invocar();
            invocar.RecibirOperacion(depositar);
            invocar.RecibirOperacion(retirar);
            
            invocar.EjecutarOperaciones();
            cuenta.Informacion();

            Momento momento = careTaker.ObtenerMomento(0);
            Momento momento2 = careTaker.ObtenerMomento(1);

            momento.ObtenerMomento().Informacion();
            momento2.ObtenerMomento().Informacion();

            originator.getEstado().Informacion(); //Ultimo Estado

            originator.Restaurar(careTaker.ObtenerMomento(0));

            originator.getEstado().Informacion(); //Estado Restaurado
            */
            #endregion

            #region Behavioral Memento
            /*
            Cuenta cuentaII = new Cuenta(50896, 50000);

            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.setEstado(cuentaII); //Estado Inicial
            careTaker.AgregarMomento(originator.Guardar());

            cuentaII = new Cuenta(50896, 55000);
            originator.setEstado(cuentaII); //Segundo Estado
            careTaker.AgregarMomento(originator.Guardar());


            cuentaII = new Cuenta(50896, 52500);
            originator.setEstado(cuentaII); //Tercer Estado
            careTaker.AgregarMomento(originator.Guardar());
            

            Momento momento = careTaker.ObtenerMomento(0);
            Momento momento2 = careTaker.ObtenerMomento(1);
            Momento momento3 = careTaker.ObtenerMomento(2);
            
            momento.ObtenerMomento().Informacion();
            momento2.ObtenerMomento().Informacion();
            momento3.ObtenerMomento().Informacion();


            originator.getEstado().Informacion(); //Ultimo Estado

            originator.Restaurar(careTaker.ObtenerMomento(0));

            originator.getEstado().Informacion(); //Estado Restaurado
            */
            #endregion

            #region Behavioral Observer
            /*CasaDeCambio casaDeCambio = new CasaDeCambio();
            new PESOARG(casaDeCambio);
            new SOLPER(casaDeCambio);
            new BSFVE(casaDeCambio);

            int estado = 10;
            Console.WriteLine($"Set estado {estado}");

            casaDeCambio.SetEstado(estado);

            estado = 25;
            Console.WriteLine($"Set estado {estado}");

            casaDeCambio.SetEstado(estado);

            estado = 50;
            Console.WriteLine($"Set estado {estado}");

            casaDeCambio.SetEstado(estado);*/

            #endregion

            #region Structural DAO
           // MainDAO mainDAO = new MainDAO();
            #endregion

            #region Creational Builder
            //MainBuilder mainBuilder = new MainBuilder();
            MainBuilderII AutomovilBuilder = new MainBuilderII();
            #endregion
            Console.ReadKey();
        }
    }
}
