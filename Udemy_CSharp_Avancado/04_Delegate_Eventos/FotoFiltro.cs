namespace _04_Delegate_Eventos
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            System.Console.WriteLine("FotoFiltro > Colorir");
        }

        public void ReduzirImagem(Foto foto)
        {
            System.Console.WriteLine("FotoFiltro > Gerar Thumb");
        }

        public void PretroBranco(Foto foto)
        {
            System.Console.WriteLine("FotoFiltro > PretroBranco");
        }

        public void Redimensionar(Foto foto)
        {
            System.Console.WriteLine("FotoFiltro > Redimensionar");
        }

    }
}