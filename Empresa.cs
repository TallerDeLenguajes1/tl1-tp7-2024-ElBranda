namespace EspacioEmpresa {
    class Empleado {
        private string Nombre;
        private string Apellido;
        private DateTime FechaNacimiento;
        private char EstadoCivil;
        private DateTime IngresoEmpresa;
        private double SueldoBasico;
        private Cargo eCargo;
        public enum Cargo {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public Empleado(string nombre, string apellido, DateTime fechnac, char estciv, DateTime ingemp, double sueldobase, Cargo eCargo) {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechnac;
            this.EstadoCivil = estciv;
            this.IngresoEmpresa = ingemp;
            this.SueldoBasico = sueldobase;
            this.eCargo = eCargo;
        }

        public string NombreCompleto() {
            return Apellido + ", " + Nombre;
        }

        public int Antiguedad() {
            return Convert.ToInt32(DateTime.Now.ToString("yyyy"))-Convert.ToInt32(IngresoEmpresa.ToString("yyyy"));
        }

        public int Edad() {
            return Convert.ToInt32(DateTime.Now.ToString("yyyy"))-Convert.ToInt32(FechaNacimiento.ToString("yyyy"));
        }

        public int Jubilacion() {
            return 65-Antiguedad();
        }

        public double Sueldo() {
            double Adicional;

            if (Antiguedad() < 20) {
                Adicional = SueldoBasico * 0.01f * Antiguedad();
            } else {
                Adicional = SueldoBasico * 0.25f;
            }

            if (eCargo == Cargo.Ingeniero || eCargo == Cargo.Especialista) {
                Adicional *= 1.5f;
            }

            if (EstadoCivil == '1') {
                Adicional += 150000;
            }

            return SueldoBasico+Adicional;
        }
    }
}