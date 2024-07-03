﻿using FitnessHelper.Models;
using FitnessHelper.Repositories.Interfaces;
using FitnessHelper.Services.Interfaces;

namespace FitnessHelper.Services.Implementatios;

public class ExerciseService : IExerciseService
{
    private readonly IExerciseRepository _exerciseRepository;

    public ExerciseService(IExerciseRepository exerciseRepository)
    {
        _exerciseRepository = exerciseRepository;
    }

    public ExerciseModel GetById(int userId, int id)
    {
        ExerciseModel exercise = _exerciseRepository.GetById(userId, id);

        return exercise;
    }

    public void AddExercise(int userId, ExerciseRequestModel exerciseRequestModel)
    {
        ExerciseModel exercise = new ExerciseModel();
        exercise.ExerciseTitle = exerciseRequestModel.ExerciseTitle;
        exercise.TrainingId = exerciseRequestModel.TrainingId;
        exercise.QtySets = exerciseRequestModel.QtySets;
        exercise.QtyReps = exerciseRequestModel.QtyReps;
        exercise.IsActive = true;
        exercise.UserId = userId;

        _exerciseRepository.AddExercise(exercise);
    }

    public void UpdateExercise(int userId, int id, ExerciseRequestModel exerciseRequestModel)
    {
        ExerciseModel exercise = _exerciseRepository.GetById(userId, id);

        exercise.ExerciseTitle = exerciseRequestModel.ExerciseTitle;
        exercise.QtySets = exerciseRequestModel.QtySets;
        exercise.QtyReps = exerciseRequestModel.QtyReps;
        exercise.IsActive = exerciseRequestModel.IsActive;

        _exerciseRepository.UpdateExercise(exercise);
    }
}
