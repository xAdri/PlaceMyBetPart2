using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class ApuestasRepository
    {
        internal List<Apuesta> Retrieve()
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.Apuesta.Include(a => a.mercado).ToList();
            }
            return apuestas;
        }

        internal Apuesta RetrieveId(int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Apuesta apuesta = context.Apuesta.FirstOrDefault(a => a.apuestaId == id);
                return apuesta;
            }
        }

        internal int RetrieveIdMercado(int idMercado)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Apuesta apuesta = context.Apuesta.FirstOrDefault(a => a.mercadoId == idMercado);
                int idApuesta = apuesta.apuestaId;
                return idApuesta;
            }
        }

        /*
        // Esta es la que estaba intentando para devolver la lista de apuestas con los Ids
        internal List<Apuesta> RetrieveIdMercado(int idMercado)
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                context.Apuesta.Include(a => a.mercadoId == idMercado).ToList();
                return apuestas;
            }
        }*/

        internal void Save(Apuesta a)
        {
            // Recuperar mercado con el mismo ID de apuesta para hacer
            // el post y si es over el dinero de la apuesta se agregue al dinero over
            // al finero de la apuesta (sumando dinero al mercado)
            PlaceMyBetContext context = new PlaceMyBetContext();
            Mercado mercado;
            mercado = context.Mercado.FirstOrDefault(m => m.mercadoId == a.mercadoId);
            a.tipoApuesta = a.tipoApuesta.ToLower();

            if (a.tipoApuesta == "over")
            {
                mercado.dineroOver += a.dineroApuesta;
                a.cuota = mercado.cuotaOver;
            }
            else if(a.tipoApuesta == "under")
            {
                mercado.dineroUnder += a.dineroApuesta;
                a.cuota = mercado.cuotaUnder;
            }

            double probabilidadOver = mercado.dineroOver / (mercado.dineroOver + mercado.dineroUnder);
            double probabilidadUnder = mercado.dineroUnder / (mercado.dineroOver + mercado.dineroUnder);

            mercado.cuotaOver = (1 / probabilidadOver) * 0.95;
            mercado.cuotaUnder = (1 / probabilidadUnder) * 0.95;

            a.fecha = DateTime.Now;
            a.tipoMercado = mercado.overUnder;
            a.eventoId = mercado.eventoId;

            context.Mercado.Update(mercado);
            context.Apuesta.Add(a);
            context.SaveChanges();
        }

        public static ApuestaDTO ToDTO(Apuesta a)
        {
            return new ApuestaDTO(a.usuarioId, a.eventoId, a.tipoApuesta, a.cuota, a.dineroApuesta);
        }

        public List<ApuestaDTO> RetrieveDTO()
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            List<ApuestaDTO> apuestas = context.Apuesta.Select(m => ToDTO(m)).ToList();
            return apuestas;
        }
    }
}