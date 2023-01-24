using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class ClassroomDto
    {
        public string RoomName { get; set; }
        public string Building { get; set; }

        public static explicit operator Classroom(ClassroomDto classroom)
        {
            return new Classroom
            {
                RoomName= classroom.RoomName,
                Building= classroom.Building,
            };
        }
        public static explicit operator ClassroomDto(Classroom classroom)
        {
            return new ClassroomDto
            {
                RoomName= classroom.RoomName,
                Building= classroom.Building,
            };
        }
    }
}
