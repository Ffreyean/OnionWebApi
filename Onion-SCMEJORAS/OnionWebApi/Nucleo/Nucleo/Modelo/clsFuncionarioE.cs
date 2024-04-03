using InfrastructuraDatos

namespace Nucleo.Modelo
{
    public class clsFuncionarioE
    {
        public string idusu { get; set; }
        public string nombre { get; set; }
        public string solonombre { get; set; }
        public string apellidos { get; set; }
        public bool tipo { get; set; }
        public bool EsAdmin { get; set; }
        public string coddej { get; set; }
        public string oficina { get; set; }
    }

    public bool Agregar(clsFuncionarioE pObjetoE)
    {
        clsFuncionariosAD V_ObjDataAccess = new clsFuncionariosAD();
        bool V_resultado = false;

        try
        {
            if (V_ObjDataAccess.Agregar(pObjetoE))
                V_resultado = true;
        }
        catch (Exception ex)
        {
            return default(Boolean);
        }
        finally
        {
            V_ObjDataAccess = null/* TODO Change to default(_) if this is not a reference type */;
        }

        return V_resultado;
    }

    public bool EsFuncionarioAsociado(clsFuncionarioE pObjetoE)
    {
        clsFuncionariosAD V_ObjDataAccess = new clsFuncionariosAD();
        bool V_resultado = false;
        try
        {
            V_resultado = V_ObjDataAccess.EsFuncionarioAsociado(pObjetoE);
        }
        catch (Exception ex)
        {
            return default(Boolean);
        }
        finally
        {
            V_ObjDataAccess = null/* TODO Change to default(_) if this is not a reference type */;
        }
        return V_resultado;
    }

    public bool Eliminar(clsFuncionarioE pObjetoE)
    {
        clsFuncionariosAD V_ObjDataAccess = new clsFuncionariosAD();
        bool V_resultado = false;
        try
        {
            if (V_ObjDataAccess.Eliminar(pObjetoE))
                V_resultado = true;
        }
        catch (Exception ex)
        {
            return default(Boolean);
        }
        finally
        {
            V_ObjDataAccess = null/* TODO Change to default(_) if this is not a reference type */;
        }
        return V_resultado;
    }

    public bool EsFuncionarioAdministrador(clsFuncionarioE pObjetoE)
    {
        clsFuncionariosAD V_ObjDataAccess = new clsFuncionariosAD();
        bool V_resultado = false;
        try
        {
            if (V_ObjDataAccess.EsFuncionarioAdministrador(pObjetoE))
                V_resultado = true;
        }
        catch (Exception ex)
        {
            return default(Boolean);
        }
        finally
        {
            V_ObjDataAccess = null/* TODO Change to default(_) if this is not a reference type */;
        }
        return V_resultado;
    }

    public bool FuncionarioPuedeIncluirInformacion(clsFuncionarioE pObjetoE)
    {
        clsFuncionariosAD V_ObjDataAccess = new clsFuncionariosAD();
        bool V_resultado = false;
        try
        {
            if (V_ObjDataAccess.FuncionarioPuedeIncluirInformacion(pObjetoE))
                V_resultado = true;
        }
        catch (Exception ex)
        {
            return default(Boolean);
        }
        finally
        {
            V_ObjDataAccess = null/* TODO Change to default(_) if this is not a reference type */;
        }
        return V_resultado;
    }


    public IEnumerable<clsFuncionarioE> GetLista(string pCoddej)
    {
        clsFuncionariosAD V_ObjDataAccess = new clsFuncionariosAD();
        IEnumerable<clsFuncionarioE> V_resultado;
        try
        {
            V_resultado = V_ObjDataAccess.GetLista(pCoddej);
        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            V_ObjDataAccess = null/* TODO Change to default(_) if this is not a reference type */;
        }

        return V_resultado;
    }


}
