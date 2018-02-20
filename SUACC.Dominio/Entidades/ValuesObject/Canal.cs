namespace SUACC.Dominio.Entidades.ValuesObject
{
    public class Canal
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public Canal()
        {

        }

        public void SetarTelefone()
        {
            Id = "A3C919B7-D476-400A-B611-F01A98501E5A";
            Nome = "Telefone";
        }

        public void SetarEmail()
        {
            Id = "E0FE0CD3-EE33-431B-980F-369797EA7C41";
            Nome = "E-mail";
        }

        public void SetarChat()
        {
            Id = "876DC8E0-30BF-472F-AC71-38F4A437AA4E";
            Nome = "Chat";
        }

        public void SetarSms()
        {
            Id = "D60F047F-ACE2-4CC1-98E8-2BC8C2B4315D";
            Nome = "Sms";
        }

        public void SetarRedeSocial()
        {
            Id = "107FAB70-DCAB-4ACD-9446-DC67B179194E";
            Nome = "RedeSocial";
        }
    }
}
