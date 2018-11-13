using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace WebApplication1.Models
{
    public class TestModel
    {
        public TestInnerModel[] InnerModels { get; set; } = new TestInnerModel[0];
    }

    public class TestInnerModel
    {
        public TestInnerModel()
        {
        }

        [ModelBinder(BinderType = typeof(NumberModelBinder))]
        public decimal Rate { get; set; }
    }
}