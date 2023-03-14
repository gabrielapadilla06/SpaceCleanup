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
                message: new QuizLabel("Según la ESA (Agencia Espacial Europea), hay más de 130 millones de objetos en el espacio que miden entre 1mm y 1 cm. ¡Y este número sigue en aumento!", 90),
                question: new QuizLabel("¿Cuántos objetos miden entre 1mm y 1cm hay en el espacio según la ESA?", 90),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Más de 130 millones") },
                    { AnswerBtn.B, new QuizLabel("Menos de 10 millones") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Algunas causas de la basura espacial son:\n- Satélites y naves espaciales dañadas,\n- Satélites que llegan al final de su vida útil,\n- Lanzamientos de cohetes,\n- Desechos por actividades espaciales (herramientas),\n- Colisiones accidentales", 64),
                question: new QuizLabel("¿Cuáles son algunas de las causas de la basura espacial?", 90),
                answers: new() {
                    { AnswerBtn.B, new QuizLabel("Satélites que llegan al final de su vida útil y herramientas espaciales", 60) },
                    { AnswerBtn.A, new QuizLabel("Solo cohetes y naves espaciales dañadas", 70) }
                },
                correctAnswer: AnswerBtn.B
            ),
            new QuizQuestion(
                message: new QuizLabel("Limpiar los desechos espaciales no es sencillo. Por eso la NASA considera importante prevenir la generación de desechos espaciales antes que buscar tecnologías costosas para remediar el problema."),
                question: new QuizLabel("¿Qué considera importante la NASA respecto a la basura espacial?", 90),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Prevenir la generación de basura espacial", 70) },
                    { AnswerBtn.B, new QuizLabel("Buscar tecnologías costosas") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("¿Sabías que en los últimos 50 años ha caído diariamente un pedazo de basura espacial en la Tierra? Sin embargo, la mayoría no sobrevive al calentamiento que se produce durante el reingreso a la Tierra."),
                question: new QuizLabel("¿Cuánto tiempo ha caído diariamente un pedazo de basura espacial en la Tierra?", 90),
                answers: new() {
                    { AnswerBtn.B, new QuizLabel("En los últimos 50 años") },
                    { AnswerBtn.A, new QuizLabel("En los últimos 500 años") }
                },
                correctAnswer: AnswerBtn.B
            ),
            new QuizQuestion(
                message: new QuizLabel("La basura espacial da vueltas alrededor de la Tierra a grandes velocidades. La ESA señala que el principal peligro de la basura espacial es el riesgo de colisión con satélites, naves y la Estación Espacial Internacional."),
                question: new QuizLabel("¿Cuál es el principal peligro de la basura espacial según la ESA?", 90),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("El riesgo de colisión") },
                    { AnswerBtn.B, new QuizLabel("El riesgo de contaminación de otros planetas", 65) }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Según un estudio, la basura espacial que orbita la Tierra podría elevar el brillo general del cielo nocturno en más del 10 % por encima de los niveles de luz natural en una gran parte del planeta."),
                question: new QuizLabel("¿Qué efecto tiene la basura espacial en el brillo general del cielo nocturno?", 90),
                answers: new() {
                    { AnswerBtn.B, new QuizLabel("Puede elevarlo en más del 10 % en parte del planeta", 65) },
                    { AnswerBtn.A, new QuizLabel("No tiene efecto") }
                },
                correctAnswer: AnswerBtn.B
            ),
            new QuizQuestion(
                message: new QuizLabel("Se considera como primera basura espacial al satélite Sputnik I lanzado por la Unión Soviética en 1957 y las piezas del cohete que fue utilizado en el lanzamiento."),
                question: new QuizLabel("¿Cuál fue el primer objeto enviado al espacio considerado como basura espacial?", 90),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("El satélite Sputnik I") },
                    { AnswerBtn.B, new QuizLabel("El satélite Vanguard I") }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("Propuestas para destruir la basura espacial son:\n - Láser: Disparar con un láser desde la Tierra y acabar con la basura de 1 a 20 cm \n - Arpones: Capturar los residuos y dirigirlos hacia la atmósfera, donde se desintegrarán \n - Vehículos colectores: vehículo para recoger la chatarra y la transportarla hacía la estación base.", 58),
                question: new QuizLabel("¿Cuáles son algunas propuestas para destruir la basura espacial?", 90),
                answers: new() {
                    { AnswerBtn.B, new QuizLabel("Láser, arpones y vehículos colectores", 70) },
                    { AnswerBtn.A, new QuizLabel("Misiles y bombas") }
                },
                correctAnswer: AnswerBtn.B
            ),
            new QuizQuestion(
                message: new QuizLabel("A medida que la cantidad de basura aumenta, la probabilidad de que se produzcan colisiones también aumenta, generando más escombros. Este efecto en cascada es denominado el síndrome de Kessler."),
                question: new QuizLabel("¿Qué causa el síndrome de Kessler?", 100),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("El aumento de la cantidad de basura espacial", 65) },
                    { AnswerBtn.B, new QuizLabel("Los efectos del espacio en el cuerpo humano", 65) }
                },
                correctAnswer: AnswerBtn.A
            ),
            new QuizQuestion(
                message: new QuizLabel("La NASA puso en marcha el “Orbital Debris Program” para monitorear y afrontar el problema de la basura espacial. Establece una serie de prácticas como la prevención, y la creación de satélites más resistentes."),
                question: new QuizLabel("¿Cuál es el objetivo del programa Orbital Debris de la NASA?", 90),
                answers: new() {
                    { AnswerBtn.B, new QuizLabel("Monitorizar y afrontar el problema de la basura espacial", 65) },
                    { AnswerBtn.A, new QuizLabel("Lanzar más satélites al espacio") }
                },
                correctAnswer: AnswerBtn.B
            ),
            new QuizQuestion(
                message: new QuizLabel("Hay dos enfoques para acabar con la basura espacial: reintroducir los objetos en la Tierra o destruirlos en el espacio exterior. Algunas misiones que se han desarrollado para terminar con la basura espacial son: RemoveDEBRIS, ClearSpace-1, OSCaR, etc."),
                question: new QuizLabel("¿Cuáles son los dos enfoques para acabar con la basura espacial?", 90),
                answers: new() {
                    { AnswerBtn.A, new QuizLabel("Reintroducir los objetos en la Tierra o destruirlos en el espacio exterior", 60) },
                    { AnswerBtn.B, new QuizLabel("Enviar más objetos al espacio o ignorar el problema", 65) }
                },
                correctAnswer: AnswerBtn.A
            ), 
        };
    }

}