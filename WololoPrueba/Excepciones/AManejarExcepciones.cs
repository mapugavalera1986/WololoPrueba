using System.Net;
using System.Text.Json;
using BadRequestException = WololoPrueba.Excepciones.BadRequestException;
using KeyNotFoundException = WololoPrueba.Excepciones.BadRequestException;
using NotFoundException = WololoPrueba.Excepciones.NotFoundException;
using UnauthorizedException = WololoPrueba.Excepciones.UnauthorizedException;

namespace WololoPrueba.Excepciones

{
    public class AManejarExcepciones
    {
        private readonly RequestDelegate _next;
        public AManejarExcepciones(RequestDelegate next) { this._next = next; }
        public async Task Invoke(HttpContext elcontexto)
        {
            try { await _next(elcontexto); }
            catch (Exception e) { await GestionarExcepcionesAsync(elcontexto, e); }
        }

        private static Task GestionarExcepcionesAsync(HttpContext elcontexto, Exception e)
        {
            HttpStatusCode codEstatus;
            DateTime momento = DateTime.Now;
            string stackTrace;
            string mensaje;
            var exType = e.GetType();
            if (exType == typeof(BadRequestException)) { codEstatus = HttpStatusCode.BadRequest; }
            else if (exType == typeof(UnauthorizedException)) { codEstatus = HttpStatusCode.Unauthorized; }
            else if (exType == typeof(KeyNotFoundException)) { codEstatus = HttpStatusCode.Unauthorized; }
            else if (exType == typeof(NotFoundException)) { codEstatus = HttpStatusCode.NotFound; }
            else { codEstatus = HttpStatusCode.NotFound; }
            mensaje = e.Message;
            stackTrace = e.StackTrace;
            var exceptionResult = JsonSerializer.Serialize(new { error = momento, mensaje, stackTrace});
            elcontexto.Response.ContentType = "application/json";
            elcontexto.Response.StatusCode = (int)codEstatus;
            return elcontexto.Response.WriteAsync(exceptionResult);
        }
    }
}
