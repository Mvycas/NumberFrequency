using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace FrequencyCalculator.Controllers;

[ApiController]
[Route("[controller]")]
public class FrequencyCalculatorController : ControllerBase
{
    [HttpPost(Name = "GetFrequency")]
    public ArrayList Post([FromBody]int[] array)
    {
        Model.Model model = new Model.Model();
        int[] numberArray = new int[array.Length];
        numberArray = array;
        var minMax = model.FindMinMax(numberArray, numberArray.Length);
        
        int min = minMax.Item1;
        int max = minMax.Item2;

        var frequency= JsonSerializer.Serialize(model.FindFrequency(numberArray, max));
        var NumArr = JsonSerializer.Serialize(model.CreateArrayFromRange(min, max));

        ArrayList result = new ArrayList();

        result.Add("Frequency: " + frequency);
        result.Add("Numbers:   " + NumArr);

        return result;

    }
}