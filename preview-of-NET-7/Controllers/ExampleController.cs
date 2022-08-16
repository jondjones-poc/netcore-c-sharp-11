using asp.net7.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace asp.net7.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ExampleController : ControllerBase
    {
        private readonly IListPattern _listPattern;

        public ExampleController(
            IListPattern listPattern)
        {
            _listPattern = listPattern;
        }

        [HttpGet]
        [Route("string")]
        public string String()
        {
            return RawStringExmaple.GetRawStringSingleline();
        }

        [HttpGet]
        [Route("StartsAndEndsWithSlice")]
        public bool StartsAndEndsWithSlice()
        {
            return _listPattern.Slice(new int[] { 1, 3, 5, 4, 39, 29, 10 });
        }

        [HttpGet]
        [Route("SliceAndDiscard")]
        public string SliceAndDiscard()
        {
            return _listPattern.SliceAndDiscard(new string[] { "DISCARD", "ONE", "TWO", "THREE", "DISCARD" });
        }

        [HttpGet]
        [Route("StartsAndEndsWithSlice/number")]
        public bool StartsAndEndsWithSlice(int number)
        {
            return _listPattern.Contains(new int[] { number });
        }

        [GenericAttributeExample<string>]
        [HttpGet]
        [Route("attributes")]
        public void AttributeExample()
        {
        }

    }
}