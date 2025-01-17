namespace QuadraticSolutionSerivce.Model
{
    public class EquationRequest
    {
        public double Co_Ef_A { get; set; }
        public double Co_Ef_B { get; set; }
        public double Co_Ef_C { get; set; }
    }

    public enum EquationType
    {
        Undetermined = 0,
        Real_And_Distinct_Root,
        Real_And_Equal_Root,
        Imaginary_Root
    }
}
