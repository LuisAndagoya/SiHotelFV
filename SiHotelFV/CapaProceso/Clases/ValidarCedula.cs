using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaProceso.Clases
{
    public class ValidarCedula
    {

        public string Validar(string DNI)
        {
            string Mensaje = "";
            bool primeraValidacion = false;

            Regex rgx = new Regex("^([0-9])*$");

            /*Obtener la provincia*/
            int Provincia = int.Parse(DNI.Substring(0, 2));

            /*Obtener tercer digito*/
            int TercerDigito = int.Parse(DNI.Substring(2, 1));

            /*Validar números */
            if (!rgx.IsMatch(DNI))
            {
                Mensaje = "La CI debe contener solo números";
                primeraValidacion = true;
            }

            /* validar que el CI tenga 10 numeros*/
            if (DNI.Length != 10)
            {
                Mensaje = "La CI debe contener 10 números";
                primeraValidacion = true;
            }

            /* validar que el CI no tenga 2222222222*/
            if (DNI.Equals("2222222222"))
            {
                Mensaje = "La CI " + DNI + " no es valido";
                primeraValidacion = true;
            }

            /* validar que el CI no tenga 2222222222*/
            if (DNI.Equals("1234567897"))
            {
                Mensaje = "La CI " + DNI + " no es valido";
                primeraValidacion = true;
            }

            /* validar que elCI no tenga 1111111111*/
            if (DNI.Equals("1111111111"))
            {
                Mensaje = "La CI " + DNI + " no es valido";
                primeraValidacion = true;
            }

            /*Validar la provincia*/
            if (Provincia < 1 || Provincia > 24 && Provincia < 30 || Provincia > 30 && DNI != "9999999999")
            {
                Mensaje = "Provincia incorrecta";
                primeraValidacion = true;
            }

            /* Tercer digito menor a 6*/
            if (TercerDigito > 5)
            {
                Mensaje = "El tercer digito es incorrecto";
                primeraValidacion = true;
            }

            if (!primeraValidacion)
            {

                /* Se agrupan los nueve primeros dígitos en dos conjuntos: los que están en posiciones impares y los que están en pares. Por ejemplo, para la cédula de identidad 1713175071, las posiciones impares serían 1, 1, 1, 5 y 7, mientras que las posiciones pares serían 7, 3, 7 y 0.*/

                /*A las posiciones impares se multiplican por dos (2). Si el resultado de esta multiplicación es mayor a nueve, se le resta nueve. Por ejemplo, si los números en posiciones impares son 1, 1, 1, 5 y 7, la multiplicación por dos de cada número sería 2, 2, 2, 10 y 14. Ya que algunos resultados son mayores a nueve, se procede a restar nueve a esos valores, quedando así: 2, 2, 2, 1 y 5.*/
                int TotParImpar = 0;

                for (int i = 0; i < 9; i++)
                {
                    int Resultado = int.Parse(DNI.Substring(i, 1));

                    if ((i+1)%2 == 0)
                    {
                        /*Pares*/
                        Resultado *= 1;
                    }
                    else
                    {
                        /*Impares*/
                        Resultado *= 2;

                        if (Resultado > 9)
                        {
                            Resultado -= 9;
                        }                
                    }

                    TotParImpar += Resultado;

                }

                /*Se obtiene el módulo 10 de la suma total anterior, es decir, se toma el dígito más a la derecha del resultado de la suma. Por ejemplo, si suma 29, el módulo 10 sería 9.*/
                int Modulo = TotParImpar % 10;
                int DigVerPro = 0;
                int DigVerDNI = 0;
                /*Si el resultado anterior es cero entonces el dígito verificador es cero, caso contrario al número 10 se le resta el resultado obtenido en el anterior paso. Por ejemplo, si el resultado del paso anterior es 9, la resta sería 10 – 9 = 1, siendo 1 el dígito verificador calculado.*/
                if (Modulo > 0)
                {
                    DigVerPro = 10 - Modulo;
                }
                else
                {
                    DigVerPro = 0;
                }



                DigVerDNI = int.Parse(DNI.Substring(9, 1));

                /* si el digito obtenido del proseso no es igual al ultimo digito de la cedula la cedula no es valida*/
                if (DigVerPro != DigVerDNI)
                {
                    Mensaje = "La CI no es valido";
                }
                
            }
            return Mensaje;
        }

    }
}

