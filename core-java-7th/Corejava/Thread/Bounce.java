/*
 * 有兩種實現多任務的方法, 這取決于操作系統在中斷程序時的行為--直接中斷而不需要事先和被中斷
 * 程序協商, 還是只有在被中斷程序同意交出控制權之后才能執行中斷. 前者被稱為'搶占式多任務';
 * 后者被稱為協作(即非搶占式)多任務. 早期的操作系統, 象Windows 3.x和Mac OS 9是協作式多任
 * 務系統，一些簡易設備（例如手機）上的操作系統也采用這種方式。UNIX/Linux、Windows NT/XP
 * （以及針對32位程序的Windows 9x）和OS X則是搶占式。搶占式多任務更加有效，但實現起來難度
 * 較大。而在協作多任務機制下，一個行為不當的程序可能會獨占所有資源，導致其它所有程序無法正
 * 常工作。
 * 
 * 那么多線程和多進程有什么區別呢？本質的區別在于每個進程有它自己的變量的完備集，線程則共享
 * 相同的數據。這聽起來似乎有些危險，事實上也的確如此。
 */
package Volume2.Corejava.Thread;

import Volume2.Corejava.Thread.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;
import java.util.*;
import javax.swing.*;

/**
 * Show an animated bouncing ball.
 * @author f3216338
 */
public class Bounce {

    public static void main(String[] args) {
        JFrame frames = new BounceFrame();
        frames.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frames.setVisible(true);
    }
}

/**
 *  A ball that moves and bounces off the edges of a rectangle
 *  @author Jedi Chou
 */
class Ball {

    /**
     * Moves the ball to the next position, reversing direction
     * if it hits one of the edges
     */
    public void move(Rectangle2D bounds) {
        x += dx;
        y += dy;
        if (x < bounds.getMinX()) {
            x = bounds.getMinX();
            dx = -dx;
        }
        if (x + XSIZE >= bounds.getMaxX()) {
            x = bounds.getMaxX() - XSIZE;
            dx = -dx;
        }
        if (y < bounds.getMinY()) {
            y = bounds.getMaxY();
            dy = -dy;
        }
        if (y + YSIZE >= bounds.getMinY()) {
            y = bounds.getMaxY() - YSIZE;
            dy = -dy;
        }
    }

    /**
     * Gets the shape of the ball at its current position.
     */
    public Ellipse2D getShape() {
        return new Ellipse2D.Double(x, y, XSIZE, YSIZE);
    }
    
    private static final int XSIZE = 15;
    private static final int YSIZE = 15;
    private double x = 0;
    private double y = 0;
    private double dx = 1;
    private double dy = 1;
}

/**
 * The panel that draws the balls
 */
class BallPanel extends JPanel {

    private ArrayList<Ball> balls = new ArrayList<Ball>();

    /**
     * Add a ball to the panel.
     * @param b the ball to add
     */
    public void add(Ball b) {
        balls.add(b);
    }

    // 注意這個方法必須寫正確，否則無法在Frame上正確顯示
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g;
        for (Ball b : balls) {
            g2.fill(b.getShape());
        }
    }
}

/**
 * The frame with panel and buttons
 */
class BounceFrame extends JFrame {

    /**
     * Constructs the frame with the panel for showing the 
     * bouncing ball and Start and Close buttons
     */
    public BounceFrame() {
        setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);
        setTitle("Bounce");

        panel = new BallPanel();
        add(panel, BorderLayout.CENTER);
        JPanel buttonPanel = new JPanel();

        addButton(buttonPanel, "Start",
                new ActionListener() {
                    public void actionPerformed(ActionEvent event) {
                        addBall();
                    }
                });
        addButton(buttonPanel, "Close",
                new ActionListener() {
                    public void actionPerformed(ActionEvent event) {
                        System.exit(0);
                    }
                });

        add(buttonPanel, BorderLayout.SOUTH);
    }

    /**
     * Adds a button to a container
     * @param c the container
     * @param title the button title
     * @param listener the action listener for the button
     */
    public void addButton(Container c, String title, ActionListener listener) {
        JButton button = new JButton(title);
        c.add(button);
        button.addActionListener(listener);
    }

    /**
     * Adds a bouncing ball to the panel and makes
     * it bounce 1000 times
     */
    public void addBall() {
        try {
            Ball ball = new Ball();
            panel.add(ball);

            for (int i = 1; i <= STEPS; i++) {
                ball.move(panel.getBounds());
                panel.paint(panel.getGraphics());
                Thread.sleep(DELAY);
            }
        } catch (InterruptedException e) {
        }
    }
    private BallPanel panel;
    public static final int DEFAULT_WIDTH = 450;
    public static final int DEFAULT_HEIGHT = 350;
    public static final int STEPS = 1000;
    public static final int DELAY = 3;
}
