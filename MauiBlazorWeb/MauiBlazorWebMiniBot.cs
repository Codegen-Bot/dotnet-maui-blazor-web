using Humanizer;

namespace MauiBlazorWeb;

public class MauiBlazorWebMiniBot : IMiniBot
{
    public void Execute()
    {
        var configuration = GraphQLOperations.GetConfiguration().Configuration;
    }
}
