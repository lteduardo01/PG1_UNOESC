using System.Collections.Generic;

public class Imovel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int NumeroComodos { get; set; }
    public string Categoria { get; set; }
    public string Localidade { get; set; }
    public string TipoNegocio { get; set; }
    public List<Imagem> Imagens { get; set; }

    public Imovel()
    {
        Imagens = new List<Imagem>();
    }
}

public class Imagem
{
    public int Id { get; set; }
    public string Url { get; set; }
    public int ImovelId { get; set; }
}
