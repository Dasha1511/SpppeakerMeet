using System;
using Xunit;
using System.Collections.Generic;
using SpeakerMeet.API.Controllers; //<— directive to add
using Microsoft.AspNetCore.Mvc;


namespace SpeakerMeet.API.Tests
{
public class SpeakerControllerSearchTests //<— to rename
    {
    [Fact]
    public void ItExists()
        {
        var controller = new SpeakerController();
        }

[Fact]
public void ItHasSearch() //Проверяем наличие метода Поиск
    {
    var controller = new SpeakerController();
    controller.Search("Jos");
    }

[Fact]
    public void ItReturnsOkObjectResult()
        {
        var controller = new SpeakerController();
        var result = controller.Search("Jos");
        Assert.NotNull(result); //Поиск принес результат?
        Assert.IsType<OkObjectResult>(result); //Результат ОК?
        }
       
        [Fact]
        public void ItReturnsCollectionOfSpeakers()
        {
            var controller = new SpeakerController();
            var result = controller.Search("Jos") as OkObjectResult;
            Assert.NotNull(result);
            Assert.NotNull(result.Value);
            Assert.IsType<List<Speaker>>(result.Value);
        }
    }
}