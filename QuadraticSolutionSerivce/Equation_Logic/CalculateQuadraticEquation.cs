using Microsoft.AspNetCore.Routing;
using QuadraticSolutionSerivce.Model;

namespace QuadraticSolutionSerivce.Equation_Logic
{
    public class CalculateQuadraticEquation
    {
        public EquationResultResponse CalculateEquation(EquationRequest request)
        {
            if(request.Co_Ef_A == 0)
            {
                return new EquationResultResponse
                {
                    ResponseCode = "400",
                    Message = "Coefficient 'a' must not be zero for the quadratic equation.",
                    EquationType = "Undetermined"

                };
            }

            double a = request.Co_Ef_A;
            double b = request.Co_Ef_B;
            double c = request.Co_Ef_C;


            #region Quadratic Equation Description

            //From the general quadratic equation given that: ax² + bx + c = 0
            //Where a, b, and c are real number and a ≠ 0

            //First I would like to state using "Sridharacharya Formula" which can as well be called "Almight Formular"

            //That is x = -b±√b²-4ac / 2a

            //Recall that Discriminate 'D' is to be determined, where D = (b² - 4ac)
            #endregion 

            double D = (b * b) - (4 * a * c);

            if(D > 0)
            {
                double root1 = (-b + Math.Sqrt(D)) / (2 * a);
                double root2 = (-b - Math.Sqrt(D)) / (2 * a);


                return new EquationResultResponse
                {
                    ResponseCode = "200",
                    Message = "Calculation Successful.",
                    EquationType = "Real and Distinct Root",
                    FirstRoot = root1,
                    SecondRoot = root2
                };
            }
            else if(D == 0)
            {
                double roots = -b / (2 * 1);

                return new EquationResultResponse
                {
                    ResponseCode = "200",
                    Message = "Calculation Successful.",
                    EquationType = "Real and Equal Root",
                    FirstRoot = roots,
                    SecondRoot = roots
                };

            }
            else
            {
                double realPart = -b / (2 * 1);
                double imaginaryPart = Math.Sqrt(-D) / (2 * a);


                return new EquationResultResponse
                {
                    ResponseCode = "200",
                    Message = "Calculation Successful.",
                    EquationType = "Imaginary Root",
                    ImaginaryRoot1 = $"{realPart} + {imaginaryPart}i",
                    ImaginaryRoot2 = $"{realPart} - {imaginaryPart}i"
                };
            }




        }
    }
}
