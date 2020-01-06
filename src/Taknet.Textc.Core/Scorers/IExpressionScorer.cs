namespace Taknet.Textc.Core.Scorers
{
    public interface IExpressionScorer
    {
        decimal GetScore(Expression expression);
    }
}