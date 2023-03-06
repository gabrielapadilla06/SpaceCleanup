namespace Constants
{
    enum GameLayer
    {
        Satellite = 8,
        Meteorite = 9,
        Powerup = 10,
    }
    
    public static class GameTag
    {
        public const string Battery = "Battery";
        public const string Shield = "Shield";
    }

    public static class UserScene
    {
        public const string Menu = "Menu";
        public const string Game = "Game";
    }

    public static class Data
    {
        public static InfoMessage[] InfoMessages = new InfoMessage[] {
           new InfoMessage("Según la ESA (Agencia Espacial Europea), hay más de 130 millones de objetos en el espacio que miden entre 1mm y 1 cm. ¡Y este número sigue en aumento!"),
           new InfoMessage(
            "Algunas causas de la basura espacial son:\n- Satélites y naves espaciales dañadas,\n- Satélites que llegan al final de su vida útil,\n- Lanzamientos de cohetes,\n- Desechos por actividades espaciales (herramientas),\n- Colisiones accidentales",
            64
           ),
           new InfoMessage("¿Qué es la basura espacial?\nLa basura espacial es cualquier objeto fabricado por el Hombre que se envía al espacio y no tiene una utilidad. Estos objetos flotan en órbita alrededor de la Tierra."),
           new InfoMessage("Se considera como primera basura espacial al satélite Sputnik I lanzado por la Unión Soviética en 1957 y las piezas del cohete que fue utilizado en el lanzamiento. "),
           new InfoMessage("¿Sabías que en los últimos 50 años ha caído diariamente un pedazo de basura espacial en la Tierra? Sin embargo, la mayoría no sobrevive al calentamiento que se produce durante el reingreso a la Tierra."),
           new InfoMessage("La basura espacial da vueltas alrededor de la Tierra a grandes velocidades. La ESA señala que el principal peligro de la basura espacial es el riesgo de colisión con satélites, naves y la Estación Espacial Internacional."),
           new InfoMessage("Según un estudio, la basura espacial que orbita la Tierra podría elevar el brillo general del cielo nocturno en más del 10 % por encima de los niveles de luz natural en una gran parte del planeta. "),
           new InfoMessage("A medida que la cantidad de basura aumenta, la probabilidad de que se produzcan colisiones también aumenta, generando más escombros. Este efecto en cascada es denominado el síndrome de Kessler. "),
           new InfoMessage("Limpiar los desechos espaciales no es sencillo. Por eso la NASA considera importante prevenir la generación de desechos espaciales antes ue buscar tecnologías costosas para remediar el problema."),
           new InfoMessage("Hay dos enfoques para acabar con la basura espacial: reintroducir los objetos en la Tierra o destruirlos en el espacio exterior. Algunas misiones que se han desarrollado para terminar con la basura espacial son: RemoveDEBRIS, ClearSpace-1, OSCaR, etc."),
           new InfoMessage("La NASA puso en marcha el “Orbital Debris Program” para monitorear y afrontar el problema de la basura espacial. Establece una serie de prácticas como la prevención, y la creación de satélites más resistentes."),
           new InfoMessage("Propuestas para destruir la basura espacial son:\n - Láser: Disparar con un láser desde la Tierra y acabar con la basura de 1 a 20 cm \n - Arpones: Capturar los residuos y dirigirlos hacia la atmósfera, donde se desintegrarán \n - Vehículos colectores: vehículo para recoger la chatarra y la transportarla hacía la estación base.", 64),
        };
    }
}