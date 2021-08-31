public class AdapterLinea implements Forma{
    private Linea adaptee;

    public AdapterLinea(Linea line) {
        this.adaptee = line;
    }

    @Override
    public void dibujar(int x1, int y1, int x2, int y2) {
        adaptee.draw(x1, y1, x2, y2);
    }
}
