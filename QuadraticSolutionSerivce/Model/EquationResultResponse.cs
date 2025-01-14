namespace QuadraticSolutionSerivce.Model
{
    public class EquationResultResponse
    {
        public string EquationType { get; set; }
        public double? FirstRoot { get; set; }
        public double? SecondRoot { get; set; }
        public string ImaginaryRoot1 { get; set; }
        public string ImaginaryRoot2 { get; set; }
        public string Message { get; set; } 
        public string ResponseCode { get; set; }
    }
}
