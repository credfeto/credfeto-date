using Credfeto.Date.Interfaces;
using FunFair.Test.Common;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Abstractions;

namespace Credfeto.Date.Tests;

public sealed class DependencyInjectionTests : DependencyInjectionTestsBase
{
    public DependencyInjectionTests(ITestOutputHelper output)
        : base(output: output, dependencyInjectionRegistration: Configure)
    {
    }

    private static IServiceCollection Configure(IServiceCollection arg)
    {
        return arg.AddDate();
    }

    [Fact]
    public void CurrentTimeSourceMustBeRegistered()
    {
        this.RequireService<ICurrentTimeSource>();
    }
}