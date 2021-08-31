public class App {
    public static void main(String[] args) throws Exception {
        Forma[] shapes = { new AdaptadorRectangulo(new Rectangulo()), new AdapterLinea(new Linea()) };
        int x1 = 10, y1 = 20;
        int x2 = 30, y2 = 60;
        for (Forma shape : shapes) {
            shape.dibujar(x1, y1, x2, y2);
        }
    }
}
