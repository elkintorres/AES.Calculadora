// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;

namespace Calculadora
{
    public partial class CalcController : ICalcController
    {

        /// <summary>
        /// Representa la operación de suma y debe ser soportada a través del verbo GET. Va a recibir los elementos a sumar como num1 y num2 como query strings - /add
        /// </summary>
        /// <param name="num1">Primer valor de la suma</param>
        /// <param name="num2">Segundo valor de la suma</param>
        /// <returns>Calculo</returns>
        public IActionResult Get(decimal num1, decimal num2)
        {
            // TODO: implement Get - route: calc/add
            var result = new Calculo()
            {
                Num1 = num1,
                Num2 = num2,
                Result = num1 + num2
            };
            return new ObjectResult(result);
        }

        /// <summary>
        /// Representa la operación de resta y debe ser soportada a través del verbo DELETE. Va a recibir sus elementos a restar como parte del cuerpo del mensaje - /sub
        /// </summary>
        /// <param name="calculo"></param>
        /// <returns>Calculo</returns>
        public IActionResult Patch(Models.Calculo calculo)
        {
            // TODO: implement Patch - route: calc/sub
            calculo.Result = calculo.Num1 - calculo.Num2;
            return new ObjectResult(calculo);
        }

        /// <summary>
        /// Representa la operación de multiplicación y debe ser soportada a través del verbo POST. Va a recibir sus elementos a multiplicar como parte del cuerpo del mensaje - /mul
        /// </summary>
        /// <param name="calculo"></param>
        /// <returns>Calculo</returns>
        public IActionResult Post(Models.Calculo calculo)
        {
            // TODO: implement Post - route: calc/mul
            calculo.Result = calculo.Num1 * calculo.Num2;
            return new ObjectResult(calculo);
        }

        /// <summary>
        /// RRepresenta la operación de división y debe ser soportada a través del verbo PUT. Va a recibir sus elementos a dividir como num1 y num2 como query strings - /div
        /// </summary>
        /// <param name="content"></param>
        /// <param name="num1">valor del dividendo</param>
        /// <param name="num2">valor del divisor</param>
        /// <returns>Calculo</returns>
        public IActionResult Put([FromBody] string content, decimal num1, decimal num2)
        {
            var result = new Calculo()
            {
                Num1 = num1,
                Num2 = num2,
                Result = (num2 == 0 ? 0 : num1 / num2)
            };
            return new ObjectResult(result);
        }
    }
}
