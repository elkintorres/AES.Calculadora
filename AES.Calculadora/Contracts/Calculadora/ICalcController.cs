// Template: Controller Interface (ApiControllerInterface.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;


namespace Calculadora
{
    public interface ICalcController
    {

        IActionResult Get(decimal num1,decimal num2);
        IActionResult Patch([FromBody] Models.Calculo calculo);
        IActionResult Post([FromBody] Models.Calculo calculo);
        IActionResult Put([FromBody] string content,decimal num1,decimal num2);
    }
}
