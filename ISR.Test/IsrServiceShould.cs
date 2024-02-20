using ISR.Core.Services;
namespace ISR.Test;

public class IsrServiceShould
{
    [Fact]
    public void WhenLimiteSupiriorIs_3500_return_67_19()
    {
        var salary = new Core.Entites.Salary { money = 3500f};
        var expected = 67.19981f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_62000_return_3621_4697()
    {
        var salary = new Core.Entites.Salary { money = 62000f};
        var expected = 3621.4697f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_1075000_return_8408_303()
    {
        var salary = new Core.Entites.Salary { money = 107500f};
        var expected = 8408.303f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_120000_return_10005_055()
    {
        var salary = new Core.Entites.Salary { money = 120000f};
        var expected = 10005.055f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_160400_return_16973_633()
    {
        var salary = new Core.Entites.Salary { money = 160400f};
        var expected = 16973.633f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_320300_return_51122_164()
    {
        var salary = new Core.Entites.Salary { money = 320300f};
        var expected = 51122.164f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_505420_return_94585_45()
    {
        var salary = new Core.Entites.Salary { money = 505420f};
        var expected = 94585.45f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_974535_return_229583_44()
    {
        var salary = new Core.Entites.Salary { money = 956500f};
        var expected = 229583.44f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_1245330_return_633499_56()
    {
        var salary = new Core.Entites.Salary { money = 1245330f};
        var expected = 633499.56f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_3785100_return_596421()
    {
        var salary = new Core.Entites.Salary { money = 3785100f};
        var expected = 596421.00f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_4200600_return_1328383()
    {
        var salary = new Core.Entites.Salary { money = 4200600f};
        var expected = 1328383.6f;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal(expected, result.Index);
    }
}