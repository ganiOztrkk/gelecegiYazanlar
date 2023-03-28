using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Form1
    {
        /*
         *  //SRP: Her nesnenin SADECE BİR sorumluluğu olmalı!
        //1. Bir nesnede değişiklik yapmak için birden fazla sebebiniz varsa; bu prensibi ihlal ediyorsunuz!
        //2. Form1 bir insan evladı olsaydı, sorumluluğunu nasıl anlatırdı?         

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

            ProductService productService = new ProductService();
            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            var affectedRows = productService.AddProduct(name, price);

            string message = affectedRows > 0 ? "Başarılı" : "İşlem yapılamadı";

            MessageBox.Show(message);


        }
         */
    }
}
