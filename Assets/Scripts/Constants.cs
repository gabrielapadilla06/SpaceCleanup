namespace Constants
{
    public enum GameLayer
    {
        Satellite = 8,
        Meteorite = 9,
        Powerup = 10,
    }

    public enum AnswerBtn
    {
        A,
        B
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

    public static class Quiz
    {
        public static QuizQuestion[] Questions = new [] {
            new QuizQuestion(
                message: new QuizLabel("Según la ESA (Agencia Espacial Europea), hay más de 130 millones de objetos en el espacio que miden entre 1mm y 1 cm. ¡Y este número sigue en aumento!"),
                question: new QuizLabel("¿Cuántos objetos miden entre 1mm y 1cm hay en el espacio según la ESA?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Más de 130 millones") },
                    { AnswerBtn.B, new QuizLabel("Menos de 10 millones") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Algunas causas de la basura espacial son:\n- Satélites y naves espaciales dañadas,\n- Satélites que llegan al final de su vida útil,\n- Lanzamientos de cohetes,\n- Desechos por actividades espaciales (herramientas),\n- Colisiones accidentales", 64),
                question: new QuizLabel("¿Cuáles son algunas de las causas de la basura espacial?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Satélites que llegan al final de su vida útil y herramientas espaciales") },
                    { AnswerBtn.B, new QuizLabel("Solo cohetes y naves espaciales dañadas") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("¿Qué es la basura espacial?\nLa basura espacial es cualquier objeto fabricado por el Hombre que se envía al espacio y no tiene una utilidad. Estos objetos flotan en órbita alrededor de la Tierra."),
                question: new QuizLabel("¿Qué es la basura espacial?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Cualquier objeto fabricado por el hombre que se envía al espacio y no tiene utilidad.") },
                    { AnswerBtn.B, new QuizLabel("Cualquier objeto que cae a la Tierra desde el espacio.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Limpiar los desechos espaciales no es sencillo. Por eso la NASA considera importante prevenir la generación de desechos espaciales antes que buscar tecnologías costosas para remediar el problema."),
                question: new QuizLabel("¿Qué considera importante la NASA respecto a la basura espacial?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Prevenir la generación de desechos espaciales antes que buscar tecnologías costosas para remediar el problema.") },
                    { AnswerBtn.B, new QuizLabel("Buscar tecnologías costosas para remediar el problema antes que prevenir la generación de desechos espaciales.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("¿Sabías que en los últimos 50 años ha caído diariamente un pedazo de basura espacial en la Tierra? Sin embargo, la mayoría no sobrevive al calentamiento que se produce durante el reingreso a la Tierra."),
                question: new QuizLabel("¿Cuánto tiempo ha caído diariamente un pedazo de basura espacial en la Tierra?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("En los últimos 50 años.") },
                    { AnswerBtn.B, new QuizLabel("Desde el lanzamiento del primer satélite.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("La basura espacial da vueltas alrededor de la Tierra a grandes velocidades. La ESA señala que el principal peligro de la basura espacial es el riesgo de colisión con satélites, naves y la Estación Espacial Internacional."),
                question: new QuizLabel("¿Cuál es el principal peligro de la basura espacial según la ESA?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("El riesgo de colisión con satélites, naves y la Estación Espacial Internacional.") },
                    { AnswerBtn.B, new QuizLabel("El riesgo de contaminación de otros planetas.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Según un estudio, la basura espacial que orbita la Tierra podría elevar el brillo general del cielo nocturno en más del 10 % por encima de los niveles de luz natural en una gran parte del planeta."),
                question: new QuizLabel("¿Qué efecto tiene la basura espacial en el brillo general del cielo nocturno?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Puede elevarlo en más del 10 % por encima de los niveles de luz natural en una gran parte del planeta.") },
                    { AnswerBtn.B, new QuizLabel("No tiene ningún efecto en el brillo del cielo nocturno.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Se considera como primera basura espacial al satélite Sputnik I lanzado por la Unión Soviética en 1957 y las piezas del cohete que fue utilizado en el lanzamiento."),
                question: new QuizLabel("¿Cuál fue el primer objeto enviado al espacio considerado como basura espacial?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("El satélite Sputnik I lanzado por la Unión Soviética y las piezas del cohete utilizado en el lanzamiento.") },
                    { AnswerBtn.B, new QuizLabel("Un pedazo de chatarra de un cohete.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Propuestas para destruir la basura espacial son:\n - Láser: Disparar con un láser desde la Tierra y acabar con la basura de 1 a 20 cm \n - Arpones: Capturar los residuos y dirigirlos hacia la atmósfera, donde se desintegrarán \n - Vehículos colectores: vehículo para recoger la chatarra y la transportarla hacía la estación base."),
                question: new QuizLabel("¿Cuáles son algunas propuestas para destruir la basura espacial?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Láser, arpones y vehículos colectores.") },
                    { AnswerBtn.B, new QuizLabel("Misiles y bombas.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("A medida que la cantidad de basura aumenta, la probabilidad de que se produzcan colisiones también aumenta, generando más escombros. Este efecto en cascada es denominado el síndrome de Kessler."),
                question: new QuizLabel("¿Cuál es el efecto en cascada que se produce cuando la cantidad de basura espacial aumenta?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("El efecto en cascada se llama síndrome de Kessler y aumenta la probabilidad de colisiones.") },
                    { AnswerBtn.B, new QuizLabel("El efecto en cascada se llama síndrome de Hoover y disminuye la probabilidad de colisiones.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("La NASA puso en marcha el “Orbital Debris Program” para monitorear y afrontar el problema de la basura espacial. Establece una serie de prácticas como la prevención, y la creación de satélites más resistentes."),
                question: new QuizLabel("¿Cuál es el objetivo del programa Orbital Debris de la NASA?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Monitorizar y abordar el problema de la basura espacial.") },
                    { AnswerBtn.B, new QuizLabel("Lanzar más satélites para aumentar la capacidad de comunicaciones.") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Hay dos enfoques para acabar con la basura espacial: reintroducir los objetos en la Tierra o destruirlos en el espacio exterior. Algunas misiones que se han desarrollado para terminar con la basura espacial son: RemoveDEBRIS, ClearSpace-1, OSCaR, etc."),
                question: new QuizLabel("¿Cuáles son los dos enfoques para acabar con la basura espacial?"),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Reintroducir los objetos en la Tierra o destruirlos en el espacio exterior.") },
                    { AnswerBtn.B, new QuizLabel("Enviar más objetos al espacio o ignorar el problema.") }
                },
                correctAnswer: AnswerBtn.A
            ),
        };
    }

}