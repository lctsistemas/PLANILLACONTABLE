using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Presentacion.Helps
{
    public class ValidacionDatos
    {
        public ValidationContext context; //atributo de DataAnnotations;
        private List<ValidationResult> resuts; //resultado de validacion => de DataAnnotations;
        private bool valid;
        private string message;

        public ValidacionDatos(Object instance)
        {
            //inicializamos contexto, como parametro mandamos instancia
            // context = new ValidationContext(instance);//en visual Studio mayor a 2010
            // context = new ValidationContext(instance, null, null);//en visual estudio 2010
            context = new ValidationContext(instance);//en VB 2019
            resuts = new List<ValidationResult>();
            valid = Validator.TryValidateObject(instance, context, resuts, true);//le enviamos true para que valide todos los datos
        }

        //VALIDAMOS 
        public bool Validate(Control ctr)
        {
            if (valid == false)
            {//si es false quiere decir que esta validando que los campos son required y enviamos mensaje
                foreach (ValidationResult item in resuts)
                {
                    message += item.ErrorMessage + "\n";
                }
                //MessageBox.Show(message, "Warnig");
                ctr.Text = message;
            }
            else
                ctr.Text = "";
            return valid;
        }

        public bool Validate()
        {
            if (valid == false)
            {
                foreach (ValidationResult item in resuts)
                {
                    message += item.ErrorMessage + "\n";
                }
                Messages.M_warning(message);
               
            }            
            return valid;
        }


    }
}
