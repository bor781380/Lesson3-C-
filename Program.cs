double CalkulateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double recult = numenator / denumenator;
    return recult;
}
double answer=CalkulateFormula(1, 2, 3, 4);
Console.WriteLine(answer);