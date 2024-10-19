class program
{
    /*Desarrollar un programa que permita al usuario gestionar una cuenta bancaria. El programa
deberá utilizar un menú que permita realizar diferentes operaciones sobre el saldo de la cuenta.
Menú de opciones:
1. Consultar saldo
2. Depositar dinero
3. Retirar dinero
4. Salir
El programa debe permitir al usuario ingresar la cantidad para depositar o retirar, actualizar el
saldo y mostrar los resultados. Si se elige la opción de retiro, debe verificar que el saldo sea
suficiente.
 */
    public static void Main()
    {
        List<cuentaBancaria> cuentaBancarias = new List<cuentaBancaria>();
        cuentaBancarias.Add(new cuentaBancaria(0));
        int opcion = 0;
        while (opcion != 4)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Mostrar(cuentaBancarias);

                    break;

                case 2:
                    double monto;
                    Console.WriteLine("Escribe el monto a depositar");
                    monto = double.Parse(Console.ReadLine());
                    Depositar(cuentaBancarias, monto);
                    break;
                case 3:
                    double montoo;
                    Console.WriteLine("Escribe el monto a retirar");
                    montoo = double.Parse(Console.ReadLine());
                    retirar(cuentaBancarias, montoo);

                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;

            }


        }
    }

    static public void Depositar(List<cuentaBancaria> cuenta, double monto)
    {
        cuenta[0].saldo += monto;
        Console.WriteLine("Monto agregado");
        Console.WriteLine("Nuevo saldo " + cuenta[0].saldo + "$");

    }
    static public void Mostrar(List<cuentaBancaria> cuenta)
    {
        Console.WriteLine("Saldo actual " + cuenta[0].saldo + "$");
    }

    static public void retirar(List<cuentaBancaria> cuenta, double monto)
    {
        if (cuenta[0].saldo < monto)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            cuenta[0].saldo -= monto;
            Console.WriteLine("Monto retirado");
            Console.WriteLine("Monto restante: " + cuenta[0].saldo);
        }
    }


}

class cuentaBancaria
{
    public double saldo;
    public cuentaBancaria(double saldo)
    {
        this.saldo = saldo;
    }

}