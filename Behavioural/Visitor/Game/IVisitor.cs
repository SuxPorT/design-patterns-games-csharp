﻿namespace DesignPatterns.Visitor.Game
{
    public interface IVisitor
    {
        void Identify(Boss boss);
        void Identify(GamePhase gamePhase);
    }
}
