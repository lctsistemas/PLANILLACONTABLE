using Newtonsoft.Json;
using System;

namespace Comun.Comunicacion
{
    public class Request : Apirest, IDisposable
    {
        //CONSUMIR API POR METODO POST

        public void Solicitar(Dapi txtdni)
        {
            Dapi da = new Dapi()
            {
                dni = txtdni.dni
            };

            string json = JsonConvert.SerializeObject(da);
            string autoriza = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpYXQiOjE1OTk2ODEzMjYsImlzcyI6ImxvY2FsaG9zdCIsInVzZXJfaWQiOjE5MX0.blDMomNOj1zIgjVuRrBroWl01zCPW0rm4D5uaD-emVU";
            dynamic respuesta = Post("http://servicio.dayangels.com/api/reniec/dni", json, autoriza);

            // OBTENER DATOS DE JSON                       
            RecuperarData.mensaje = respuesta.mensaje.ToString();
            if (RecuperarData.mensaje.Contains("found data"))
            {
                RecuperarData.nombres = respuesta.response.nombres.ToString();
                RecuperarData.paterno = respuesta.response.paterno.ToString();
                RecuperarData.materno = respuesta.response.materno.ToString();
            }

        }



        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
