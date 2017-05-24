using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckboxTest.Models {
    public class TestViewModel {
        [RequiredArray(ErrorMessage = "Required Group Test Error")]
        public Guid[] RequiredGroupTest { get; set; }

        public TestViewModel() {
            this.RequiredGroupTest = new Guid[] { };
        }
        
        public class RequiredArrayAttribute : ValidationAttribute, IClientValidatable {
            public override bool IsValid(object value) {
                var val = value as Array;

                return (val != null && val.Length > 0);
            }

            public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context) {
                yield return new ModelClientValidationRule {
                    ValidationType = "requiredarray"
                    , ErrorMessage = this.ErrorMessage
                };
            }
        }
    }
}