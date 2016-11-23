using Microsoft.Xna.Framework.Input;

namespace Platformer
{
    public class InputManager
    {
        public KeyboardState prevKeyState, keyState;
        public MouseState prevMouseState, mouseState;


        public bool Q, W, E, R, T, Y, U, I, O, P, A, S, D,
            F, G, H, J, K, L, Z, X, C, V, B, N, M,
            Space, Shift, Tab, ESC, CTR, N1, N2, N3,
            N4, N5, N6, N7, N8, N9, N0, QSing, WSing,
            ESing, RSing, TSing, YSing, USing, ISing,
            OSing, PSing, ASing, SSing, DSing, FSing,
            GSing, HSing, JSing, KSing, LSing, ZSing,
            XSing, CSing, VSing, BSing, NSing, MSing,
            SpaceSing, ShiftSing, TabSing, ESCSing, CTRSing,
            N1Sing, N2Sing, N3Sing, N4Sing, N5Sing, N6Sing,
            N7Sing, N8Sing, N9Sing, N0Sing, LMB, LMBSing,
            RMB, RMBSing = false;

        public void GetInput()
        {
            prevKeyState = keyState;
            keyState = Keyboard.GetState();
            prevMouseState = mouseState;
            mouseState = Mouse.GetState();

            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                LMB = true;
            }

            else LMB = false;

            if (mouseState.RightButton == ButtonState.Pressed)
            {
                RMB = true;
            }

            else RMB = false;

            if (mouseState.LeftButton == ButtonState.Pressed && prevMouseState.LeftButton == ButtonState.Released)
            {
                LMBSing = true;
            }

            else LMBSing = false;

            if (mouseState.RightButton == ButtonState.Pressed && prevMouseState.RightButton == ButtonState.Released)
            {
                RMBSing = true;
            }

            else RMBSing = false;

            if (keyState.IsKeyDown (Keys.Q))
            {
                Q = true;   
            }
            else Q = false;

            if (keyState.IsKeyDown(Keys.W))
            {
                W = true;
            }

            else W = false;


            if (keyState.IsKeyDown(Keys.E))
            {
                E = true;
            }

            else E = false;

            if (keyState.IsKeyDown(Keys.R))
            {
                R = true;
            }

            else R = false;

            if (keyState.IsKeyDown(Keys.T))
            {
                T = true;
            }

            else T = false;

            if (keyState.IsKeyDown(Keys.U))
            {
                U = true;
            }

            else U = false;

            if (keyState.IsKeyDown(Keys.I))
            {
                I = true;
            }

            else I = false;

            if (keyState.IsKeyDown(Keys.O))
            {
                O = true;
            }

            else O = false;

            if (keyState.IsKeyDown(Keys.P))
            {
                P = true;
            }

            else P = false;

            if (keyState.IsKeyDown(Keys.A))
            {
                A = true;
            }

            else A = false;

            if (keyState.IsKeyDown(Keys.S))
            {
                S = true;
            }

            else S = false;

            if (keyState.IsKeyDown(Keys.D))
            {
                D = true;
            }

            else D = false;

            if (keyState.IsKeyDown(Keys.F))
            {
                F = true;
            }

            else F = false;

            if (keyState.IsKeyDown(Keys.G))
            {
                G = true;
            }

            else G = false;

            if (keyState.IsKeyDown(Keys.H))
            {
                H = true;
            }

            else H = false;

            if (keyState.IsKeyDown(Keys.J))
            {
                J = true;
            }

            else J = false;

            if (keyState.IsKeyDown(Keys.K))
            {
                K = true;
            }

            else K = false;

            if (keyState.IsKeyDown(Keys.L))
            {
                L = true;
            }

            else L = false;

            if (keyState.IsKeyDown(Keys.Z))
            {
                Z = true;
            }

            else Z = false;

            if (keyState.IsKeyDown(Keys.X))
            {
                X = true;
            }

            else X = false;

            if (keyState.IsKeyDown(Keys.C))
            {
                C = true;
            }

            else C = false;

            if (keyState.IsKeyDown(Keys.V))
            {
                V = true;
            }

            else V = false;

            if (keyState.IsKeyDown(Keys.B))
            {
                B = true;
            }

            else B = false;

            if (keyState.IsKeyDown(Keys.N))
            {
                N = true;
            }

            else N = false;

            if (keyState.IsKeyDown(Keys.M))
            {
                M = true;
            }

            else M = false;

            if (keyState.IsKeyDown(Keys.Space))
            {
                Space = true;
            }

            else Space = false;

            if (keyState.IsKeyDown(Keys.Tab))
            {
                Tab = true;
            }

            else Tab = false;

            if (keyState.IsKeyDown(Keys.LeftShift))
            {
                Shift = true;
            }

            else Shift = false;

            if (keyState.IsKeyDown(Keys.Escape))
            {
                ESC = true;
            }

            else ESC = false;

            if (keyState.IsKeyDown(Keys.LeftControl))
            {
                CTR = true;
            }

            else CTR = false;

            if (keyState.IsKeyDown(Keys.D1))
            {
                N1 = true;
            }

            else N1 = false;

            if (keyState.IsKeyDown(Keys.D2))
            {
                N2 = true;
            }

            else N2 = false;

            if (keyState.IsKeyDown(Keys.D3))
            {
                N3 = true;
            }

            else N3 = false;

            if (keyState.IsKeyDown(Keys.D4))
            {
                N4 = true;
            }

            else N4 = false;

            if (keyState.IsKeyDown(Keys.D5))
            {
                N5 = true;
            }

            else N5 = false;

            if (keyState.IsKeyDown(Keys.D6))
            {
                N6 = true;
            }

            else N6 = false;

            if (keyState.IsKeyDown(Keys.D7))
            {
                N7 = true;
            }

            else N7 = false;

            if (keyState.IsKeyDown(Keys.D8))
            {
                N8 = true;
            }

            else N8 = false;

            if (keyState.IsKeyDown(Keys.D9))
            {
                N9 = true;
            }

            else N9 = false;

            if (keyState.IsKeyDown(Keys.D0))
            {
                N0 = true;
            }

            else N0 = false;

            if (keyState.IsKeyDown(Keys.Q) && prevKeyState.IsKeyUp(Keys.Q))
            {
                QSing = true;
            }

            else QSing = false;

            if (keyState.IsKeyDown(Keys.W) && prevKeyState.IsKeyUp(Keys.W))
            {
                WSing = true;
            }

            else WSing = false;

            if (keyState.IsKeyDown(Keys.E) && prevKeyState.IsKeyUp(Keys.E))
            {
                ESing = true;
            }

            else ESing = false;

            if (keyState.IsKeyDown(Keys.R) && prevKeyState.IsKeyUp(Keys.R))
            {
                RSing = true;
            }

            else RSing = false;

            if (keyState.IsKeyDown(Keys.T) && prevKeyState.IsKeyUp(Keys.T))
            {
                TSing = true;
            }

            else TSing = false;

            if (keyState.IsKeyDown(Keys.Y) && prevKeyState.IsKeyUp(Keys.Y))
            {
                YSing = true;
            }

            else YSing = false;

            if (keyState.IsKeyDown(Keys.U) && prevKeyState.IsKeyUp(Keys.U))
            {
                USing = true;
            }

            else USing = false;

            if (keyState.IsKeyDown(Keys.I) && prevKeyState.IsKeyUp(Keys.I))
            {
                ISing = true;
            }

            else ISing = false;

            if (keyState.IsKeyDown(Keys.O) && prevKeyState.IsKeyUp(Keys.O))
            {
                OSing = true;
            }

            else OSing = false;

            if (keyState.IsKeyDown(Keys.P) && prevKeyState.IsKeyUp(Keys.P))
            {
                PSing = true;
            }

            else PSing = false;

            if (keyState.IsKeyDown(Keys.A) && prevKeyState.IsKeyUp(Keys.A))
            {
                ASing = true;
            }

            else ASing = false;

            if (keyState.IsKeyDown(Keys.S) && prevKeyState.IsKeyUp(Keys.S))
            {
                SSing = true;
            }

            else SSing = false;

            if (keyState.IsKeyDown(Keys.D) && prevKeyState.IsKeyUp(Keys.D))
            {
                DSing = true;
            }

            else DSing = false;

            if (keyState.IsKeyDown(Keys.D) && prevKeyState.IsKeyUp(Keys.D))
            {
                DSing = true;
            }

            else DSing = false;

            if (keyState.IsKeyDown(Keys.F) && prevKeyState.IsKeyUp(Keys.F))
            {
                FSing = true;
            }

            else FSing = false;

            if (keyState.IsKeyDown(Keys.G) && prevKeyState.IsKeyUp(Keys.G))
            {
                GSing = true;
            }

            else GSing = false;

            if (keyState.IsKeyDown(Keys.H) && prevKeyState.IsKeyUp(Keys.H))
            {
                HSing = true;
            }

            else HSing = false;

            if (keyState.IsKeyDown(Keys.J) && prevKeyState.IsKeyUp(Keys.J))
            {
                JSing = true;
            }

            else JSing = false;

            if (keyState.IsKeyDown(Keys.K) && prevKeyState.IsKeyUp(Keys.K))
            {
                KSing = true;
            }

            else KSing = false;

            if (keyState.IsKeyDown(Keys.L) && prevKeyState.IsKeyUp(Keys.L))
            {
                LSing = true;
            }

            else LSing = false;

            if (keyState.IsKeyDown(Keys.Z) && prevKeyState.IsKeyUp(Keys.Z))
            {
                ZSing = true;
            }

            else ZSing = false;

            if (keyState.IsKeyDown(Keys.X) && prevKeyState.IsKeyUp(Keys.X))
            {
                XSing = true;
            }

            else XSing = false;

            if (keyState.IsKeyDown(Keys.C) && prevKeyState.IsKeyUp(Keys.C))
            {
                CSing = true;
            }

            else CSing = false;

            if (keyState.IsKeyDown(Keys.V) && prevKeyState.IsKeyUp(Keys.V))
            {
                VSing = true;
            }

            else VSing = false;

            if (keyState.IsKeyDown(Keys.B) && prevKeyState.IsKeyUp(Keys.B))
            {
                BSing = true;
            }

            else BSing = false;

            if (keyState.IsKeyDown(Keys.N) && prevKeyState.IsKeyUp(Keys.N))
            {
                NSing = true;
            }

            else NSing = false;

            if (keyState.IsKeyDown(Keys.M) && prevKeyState.IsKeyUp(Keys.M))
            {
                MSing = true;
            }

            else MSing = false;

            if (keyState.IsKeyDown(Keys.Tab) && prevKeyState.IsKeyUp(Keys.Tab))
            {
                TabSing = true;
            }

            else TabSing = false;

            if (keyState.IsKeyDown(Keys.Space) && prevKeyState.IsKeyUp(Keys.Space))
            {
                SpaceSing = true;
            }

            else SpaceSing = false;

            if (keyState.IsKeyDown(Keys.LeftShift) && prevKeyState.IsKeyUp(Keys.LeftShift))
            {
                ShiftSing = true;
            }

            else ShiftSing = false;

            if (keyState.IsKeyDown(Keys.Escape) && prevKeyState.IsKeyUp(Keys.Escape))
            {
                ESCSing = true;
            }

            else ESCSing = false;

            if (keyState.IsKeyDown(Keys.LeftControl) && prevKeyState.IsKeyUp(Keys.LeftControl))
            {
                CTRSing = true;
            }

            else CTRSing = false;

            if (keyState.IsKeyDown(Keys.D1) && prevKeyState.IsKeyUp(Keys.D1))
            {
                N1Sing = true;
            }

            else N1Sing = false;

            if (keyState.IsKeyDown(Keys.D2) && prevKeyState.IsKeyUp(Keys.D2))
            {
                N2Sing = true;
            }

            else N2Sing = false;

            if (keyState.IsKeyDown(Keys.D3) && prevKeyState.IsKeyUp(Keys.D3))
            {
                N3Sing = true;
            }

            else N3Sing = false;

            if (keyState.IsKeyDown(Keys.D4) && prevKeyState.IsKeyUp(Keys.D4))
            {
                N4Sing = true;
            }

            else N4Sing = false;

            if (keyState.IsKeyDown(Keys.D5) && prevKeyState.IsKeyUp(Keys.D5))
            {
                N5Sing = true;
            }

            else N5Sing = false;

            if (keyState.IsKeyDown(Keys.D6) && prevKeyState.IsKeyUp(Keys.D6))
            {
                N6Sing = true;
            }

            else N6Sing = false;

            if (keyState.IsKeyDown(Keys.D7) && prevKeyState.IsKeyUp(Keys.D7))
            {
                N7Sing = true;
            }

            else N7Sing = false;

            if (keyState.IsKeyDown(Keys.D8) && prevKeyState.IsKeyUp(Keys.D8))
            {
                N8Sing = true;
            }

            else N8Sing = false;

            if (keyState.IsKeyDown(Keys.D9) && prevKeyState.IsKeyUp(Keys.D9))
            {
                N9Sing = true;
            }

            else N9Sing = false;

            if (keyState.IsKeyDown(Keys.D0) && prevKeyState.IsKeyUp(Keys.D0))
            {
                N0Sing = true;
            }

            else N0Sing = false;
        }


    }
}
