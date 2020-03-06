namespace ProAgil.WebAPI.Model
{
    public class Evento
    {
        public Evento(int eventoId, string local, string dataEvento, string tema, int qtdPessoas, string lote) 
        {
            this.EventoId = eventoId;
                this.Local = local;
                this.DataEvento = dataEvento;
                this.Tema = tema;
                this.QtdPessoas = qtdPessoas;
                this.Lote = lote;
               
        }
                public int EventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
    }
}