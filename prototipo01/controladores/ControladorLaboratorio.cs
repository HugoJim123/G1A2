﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using prototipo01.controladores;
using prototipo01.Dto;
using prototipo01.models;


namespace prototipo01.controladores
{
    class ControladorLaboratorio
    {
        //Lista de laboratorios capa Dto
        public BindingList<laboratorioDto> listLaboratorios()
        {

            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var Query = (from n in db.laboratorio
                                 select new laboratorioDto
                                 {

                                     id_laboratorio = n.id_laboratorio,
                                     descripcion_laboratorio = n.descripcion_laboratorio,
                                     CATEDRATICO_dpi_catedratico = n.CATEDRATICO_dpi_catedratico,
                                     HORARIO_id_horario = n.HORARIO_id_horario,
                                     SALON_id_salon = n.SALON_id_salon

                                 }).ToList();

                    BindingList<laboratorioDto> result = new BindingList<laboratorioDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }



        //get salones

        public List<salon> getSalones()
        {


            using (ModelDADOS db = new ModelDADOS())
            {
                var std = (from salon in db.salon
                           select salon).ToList();


                return std;
            }

        }


        //get catedraticos

        public List<catedratico> getCatedraticos()
        {


            using (ModelDADOS db = new ModelDADOS())
            {
                var std = (from catedratico in db.catedratico
                           select catedratico).ToList();


                return std;
            }

        }




        //Metodo para guardar un nuevo laboratorio
        public void guardarlaboratorio(string nombre_laboratorio, int dpi_catedratico, int id_horario, int id_salon)
        {

            using (ModelDADOS db = new ModelDADOS())
            {

                laboratorio laboratorioNuevo = new laboratorio();

                laboratorioNuevo.descripcion_laboratorio = nombre_laboratorio;
                laboratorioNuevo.CATEDRATICO_dpi_catedratico = dpi_catedratico;
                laboratorioNuevo.HORARIO_id_horario = id_horario;
                laboratorioNuevo.SALON_id_salon = id_salon;

                db.laboratorio.Add(laboratorioNuevo);
                db.SaveChanges();

            }

        }


        //Metodo para actualizar laboratorio
        public void actualizarLaboratorio(int id_laboratorio,string nombre_laboratorio, int dpi_catedratico, int id_horario,int id_salon)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.laboratorio
                        .Where(s => s.id_laboratorio== id_laboratorio)
                        .FirstOrDefault<laboratorio>();


                    std.descripcion_laboratorio = nombre_laboratorio;
                    std.CATEDRATICO_dpi_catedratico = dpi_catedratico;
                    std.HORARIO_id_horario = id_horario;
                    std.SALON_id_salon = id_salon;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }





        //obtener id del edificio
        public int getIdEdificio(string nombre_edificio)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.edificio
                        .Where(s => s.nombre_edificio == nombre_edificio)
                        .FirstOrDefault<edificio>();

                    return std.id_edificio;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }


        //Buscar salon
        public salon buscarSalon(int id_salon)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.salon
                        .Where(s => s.id_salon == id_salon)
                        .FirstOrDefault<salon>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo para eliminar un salon
        public void eliminarSalon(int id_salon)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.salon
                        .Where(s => s.id_salon == id_salon)
                        .FirstOrDefault<salon>();

                    db.salon.Remove(std);
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
