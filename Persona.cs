namespace Parejas
{
    public class Persona
    {
        public int Edad {get; set;}
        
        

           public string[] Rango(int[] edad){
         string[] nuevo = new string[10];
          for(int i=0; i< edad.Length && edad[i] != null ; i++){
           nuevo[i]=RangoDeEdad(edad[i])+"";
          }
          return nuevo;

        }
       public string RangoDeEdad(int persona){
        string res=null;
           
            if(persona>=0 && persona<=19){
              res ="Muy Joven";
            }else if (persona>=20 && persona<=29){
               res = "Joven";
            }else  if (persona>=30 && persona<=39){
               res = "Plenitud";
            }else  if (persona>=40 && persona<=49){
               res = "Madurez";
               }else{
                   res = "vejez";
               }
        
         return res;

          
        }

        public override string ToString() => $"A codificar";

       
    }
}