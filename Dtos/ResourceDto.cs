using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Domain.Enums;

namespace Domain.Dtos
{
    public class ResourceDto
    {
        public ResourceDto(string resourceTitle, decimal price, AccessType? accessType, Subject? subject, Level? level,
            ExamBoard? examBoard, bool isExamPractice, bool isExercise, string createdBy, ResourceStatus? resourceStatus, string description)
        {
            ResourceTitle = resourceTitle;
            Price = price;
            AccessType = accessType;
            Subject = subject;
            Level = level;
            ExamBoard = examBoard;
            IsExamPractice = isExamPractice;
            IsExercise = isExercise;
            CreatedBy = createdBy;
            ResourceStatus = resourceStatus;
            Description = description;
        }

        public ResourceDto() { }

        //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual string ResourceTitle { get; set; }

        public virtual decimal Price { get; set; }

        public virtual AccessType? AccessType { get; set; }

        public virtual Subject? Subject { get; set; }

        public virtual Level? Level { get; set; }

        public virtual ExamBoard? ExamBoard { get; set; }

        public virtual bool IsExamPractice { get; set; } = false;

        public virtual bool IsExercise { get; set; } = false;

        public virtual string CreatedBy { get; set; }

        public virtual ResourceStatus? ResourceStatus { get; set; }

        public virtual string Description { get; set; }
        public virtual ResourceType ResourceType { get; set; } = ResourceType.PDF;
    }
}
