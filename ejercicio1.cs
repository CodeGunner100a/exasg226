        //ejercicio 1 ----------------------------------------------- aaa
         public void CargarRndSinRep(int n1)
        {
            Random r = new Random();
            n = 0;

            while (n < n1)
            {
                int ele = r.Next(1, 101);

                if (Buscar_ele(ele) == false)
                    insertar(ele);
            }
        }

        public bool Buscar_ele(int ele)
        {
            int i = 1;
            bool ban = false;

            while ((i <= n) && (ban == false))
            {
                if (v[i] == ele)
                    ban = true;
                else
                    i++;
            }

            return ban;
        }


        public void insertar(int ele)
        {
            n = n + 1;
            v[n] = ele;
        }


     //llamada  ejercicio1
            v1.CargarRndSinRep(int.Parse(textBox1.Text));

            //textBox5.Text = v1.Descargar();
