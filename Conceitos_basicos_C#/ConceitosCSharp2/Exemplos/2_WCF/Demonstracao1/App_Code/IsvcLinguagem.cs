﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsvcLinguagem
{
    [OperationContract]
    List<Linguagem> Listar();

    [OperationContract]
    void Inserir(Linguagem pLinguagem);
}
