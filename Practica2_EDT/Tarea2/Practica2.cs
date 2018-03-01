using System;
using System.Windows.Forms;
using System.IO;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirBmp_Click(object sender, EventArgs e)
        {
            sacarDatosDeBMP();
        }

        private void btnGenerarXml_Click(object sender, EventArgs e)
        {
            archXml();
        }
       
        //Este método valida si la imagen que se selecciona contiene 
        //los caracteres "B" y "M" los cuales corresponden a un Bitmap
        public void sacarDatosDeBMP()
        {
            bmp.ShowDialog();
            FileStream file = new FileStream(bmp.FileName, FileMode.Open);

            BinaryReader primerosCaracteres = new BinaryReader(file);

            char B, M;
            B = primerosCaracteres.ReadChar();
            M = primerosCaracteres.ReadChar();

            if (B == 'B' & M == 'M')
            {
                Int64 tam;
                Int32 ancho, alt, pixls;
                tam = primerosCaracteres.ReadInt64();
                file.Seek(18, SeekOrigin.Begin);
                ancho = primerosCaracteres.ReadInt32();
                alt = primerosCaracteres.ReadInt32();
                file.Seek(28, SeekOrigin.Begin);
                pixls = primerosCaracteres.ReadInt32();
                txtInfoBmp.Text = "Imagen tipo BMP\r\n" + "Tamanio: " + tam + " KiloBytes \r\n" + "Ancho: " + ancho + "Pixeles \r\n" + "Altura : " + alt + "  Pixeles\r\n " +
                    "bit por pixel: " + pixls + " bits ";

            }
            else
            {
                MessageBox.Show("Selecciona una imagen tipo BMP");
            }


            primerosCaracteres.Close();
            file.Close();
        }
        //Método para crear un archivo xml, usando los datos de entrada en cinco cajas de texto
        public void archXml()
        {
            xml.ShowDialog();
            xml.Filter = "XML | *.xml";
            FileStream file = new FileStream(xml.FileName, FileMode.Create);
            StreamWriter br = new StreamWriter(file);
            br.WriteLine("<?xml version=\"1.0\"?>\r\n" + "\t<data>" + "<Name>" + txtD1.Text + "</Name>\r\n"
               + "\t<Lastname>" + txtD2.Text + "</Lastname>\r\n" +
               "\t<E-mail>" + txtD3.Text + "</E-mail>\r\n" +
               "\t<Street>" + txtD4.Text + "</Street>\r\n" +
               "\t<Phone number>" + txtD5.Text + "</Phone number>\r\n" + "\t</data>");
            br.Close();
            file.Close();

        }
    }   
    
}
