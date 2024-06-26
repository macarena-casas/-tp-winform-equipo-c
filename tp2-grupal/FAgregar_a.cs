﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;


namespace tp2_grupal
{
    public partial class FAgregar_a : Form
    {
        private Articulos articulos = null;
        public FAgregar_a()
        {
            InitializeComponent();
        }
                public FAgregar_a(Articulos art)
        {
            InitializeComponent();
            this.articulos = art;
        }
        
        private void tb_nombrea_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_nom_art_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A_agregar_A_Click(object sender, EventArgs e)
        {
            
            ArticulosNegocio negocio = new ArticulosNegocio();
         

            try
            {
                if (articulos == null)
                    articulos = new Articulos();
                Imagen imagen = new Imagen();
                articulos.codigo_a = tb_codigoa.Text;
                articulos.nombre_a = tb_nombrea.Text;
                articulos.marca_a = (Marca) cb_marcas_a.SelectedItem;
                articulos.categoria_a = (Categoria)cb_categorias_a.SelectedItem;
                articulos.urlimagen = tb_urlimagen.Text;
                articulos.descripcion_a = r_detalle_a.Text;
                if (!solonumeros(tb_precioa.Text))
                articulos.precio_a = decimal.Parse(tb_precioa.Text);
               
                if (articulos.Id_a!= 0)
                { negocio.modificar(articulos);
                    MessageBox.Show("Modificado con Exito");
                    Close();
                 
                } else
                {  
                    if (articulos.codigo_a != "" && articulos.nombre_a != "" && articulos.descripcion_a!="" && !solonumeros(tb_precioa.Text))
                    {
                        negocio.agregar(articulos);
                    MessageBox.Show("Agregado con Exito");
                    Close();
                    }
                    else
                    {
                        MessageBox.Show("complete todos los campos antes de agregar");
                    }
                }
                 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
       
        public bool solonumeros(string cadena)
        {
            if (cadena == "")
                {
                    return true;
                }
            foreach (char c in cadena)
            {
              
                if (!(char.IsNumber(c)))
                {
                    return true;
                }

            }
            return false;

        }
        private void FAgregar_a_Load(object sender, EventArgs e)
        {
            marca_negocio marcanegocio = new marca_negocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();

            try
            {
            cb_marcas_a.DataSource = marcanegocio.Listar();
            cb_marcas_a.ValueMember = "Codigo";
            cb_marcas_a.DisplayMember = "Nombre";   
            cb_categorias_a.DataSource = categorianegocio.listar();
            cb_categorias_a.ValueMember = "codigo_categoria";
            cb_categorias_a.DisplayMember = "nombre_categoria";
                if (articulos != null)
                { 
                    tb_nombrea.Text = articulos.nombre_a;
                    tb_codigoa.Text = articulos.codigo_a;

                    if (solonumeros(tb_precioa.Text.ToString()))
                    {
                        return;
                    }
                    tb_precioa.Text = articulos.precio_a.ToString();
                    
                    r_detalle_a.Text = articulos.descripcion_a;
                  
                    cb_categorias_a.SelectedValue = articulos.categoria_a.codigo_categoria;
                    if (cb_categorias_a.SelectedValue == null)
                    {
                        cb_categorias_a.ValueMember = "codigo_categoria";
                    }
                    cb_marcas_a.SelectedValue = articulos.marca_a.Codigo;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
         
        }

        private void cb_marcas_a_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_urlimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tb_urlimagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {

                pb_agregar.Load(imagen);

            }
            catch (Exception ex)
            {
                pb_agregar.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }
    }
}
