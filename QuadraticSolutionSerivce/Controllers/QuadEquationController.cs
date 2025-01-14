using Microsoft.AspNetCore.Mvc;
using QuadraticSolutionSerivce.Equation_Logic;
using QuadraticSolutionSerivce.Model;

namespace QuadraticSolutionSerivce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuadEquationController : ControllerBase
    {
        private readonly CalculateQuadraticEquation _calculateQuadraticEquation;
        private EquationResultResponse _equationResult;
        public QuadEquationController(CalculateQuadraticEquation calculateQuadraticEquation)
        {
            _calculateQuadraticEquation = calculateQuadraticEquation;
            _equationResult = new EquationResultResponse();
        }

        [HttpPost]
        public IActionResult CalculateEquation(EquationRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invaild Request. Please Provide Valid Co-efficients value.");
            }


            _equationResult = _calculateQuadraticEquation.CalculateEquation(request);

            return Ok(_equationResult);
        }
      
    }
}
