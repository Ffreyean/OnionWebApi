using System.Data;
using Dapper;



namespace InfrastructuraDatos
 {
    public class FuncionarioRepository
    {
        private readonly string connectionString;

        public FuncionarioRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Agregar(clsFuncionarioE funcionario)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@idusu", funcionario.idusu, DbType.String);
                parameters.Add("@nombre", funcionario.nombre, DbType.String);
                parameters.Add("@apellidos", funcionario.apellidos, DbType.String);
                parameters.Add("@tipo", funcionario.tipo, DbType.Boolean);
                parameters.Add("@EsAdmin", funcionario.EsAdmin, DbType.Boolean);
                parameters.Add("@coddej", funcionario.coddej, DbType.String);

                var rowsAffected = connection.Execute("GuardarFuncionario", parameters, commandType: CommandType.StoredProcedure);
                return rowsAffected > 0;
            }
        }

        // Implementa otras operaciones CRUD y métodos necesarios
    }
}
