using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;

namespace TRAINING
{
    public class Carro
    { 
      public string Marca{get;set;}  
      public int Modelo{get;set;}
      public float Posicion{get;set;}
      public string Version{get;set;}
      public Carro (string marca,int modelo,string version){
          Marca=marca;
          Modelo=modelo;
          Version=version; 
          Posicion=0;

      }
      public void Avanzar (){
          Posicion=Posicion +(float) 0.5;
        
      }
      public void Retroceder (){
        Posicion=Posicion -(float)0.5; 
      }
    } 
}