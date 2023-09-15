using ResumeBuilder.Data.Models;
using System.Text.Json;

namespace ResumeBuilder.Data.Factories
{
    public class JobFactory
    {
        public class SudoJobContext
        {
            public SudoJobContext()
            {
                Role = new List<Job>();
                Contact = new List<Contact>();
                Experience = new List<JobExperience>();
            }

            public List<Job> Role { get; set; }
            public List<Contact> Contact { get; set; }
            public List<JobExperience> Experience { get; set; }
        }

        private static SudoJobContext? JobContext { get; set; }

        public static SudoJobContext Run()
        {
            //using (var context = new JobContext())
            if (true)
            {
                var context = new SudoJobContext();
                // Ensure the database if not exists.
                //context.Database.EnsureCreated();

                // Add Jobs
                if (JobContext == null)
                {
                    var burgerKing = new Job
                    {
                        Title = "Burger King",
                        Location = "Ogden, UT",
                        Start = new DateTime(2018, 8, 1),
                        End = new DateTime(2018, 8, 1),
                        Summary = "Fry Cook at Burgerking",
                        Role = "Cook"
                    };

                    var farrBetterIceCream = new Job
                    {
                        Title = "Farr Better Ice Cream",
                        Location = "Ogden, UT",
                        Start = new DateTime(2018, 8, 1),
                        End = new DateTime(2019, 9, 1),
                        Summary = "Customer service representative who trained new workers, cleaned the workplace, handled money, answered phones, and provided excellent customer service.",
                        Role = "Supervisor"
                    };

                    var unitedWayOfNorthernUtah = new Job
                    {
                        Title = "United Way Of Northern Utah",
                        Location = "Ogden, UT",
                        Start = new DateTime(2019, 12, 1),
                        End = new DateTime(2023, 6, 1),
                        Summary = "Build software solutions for businesses such as websites and spreadsheets.Design reports and summaries for business growth for government reporting. Design reports for employees to fill out. Create spreadsheets or software to summarize information for governmental reporting.",
                        Role = "Software Developer"
                    };

                    var constellationSoftwareEngineering = new Job
                    {
                        Title = "Constellation Software Engineering",
                        Location = "Hill AFB, UT",
                        Start = new DateTime(2021, 9, 1),
                        End = new DateTime(2021, 11, 1),
                        Summary = "Digitized charts from TOs and POs.Put charts in the system for software to calculate gasoline usage, plane climb rate, and maximum speed for Air Force Crafts.Input the information into software.",
                        Role = "Data Analyst"
                    };

                    var agovX = new Job
                    {
                        Title = "AgovX",
                        Location = "Hill AFB, UT",
                        Start = new DateTime(2021, 11, 1),
                        End = new DateTime(2022, 9, 1),
                        Summary = "Design, plan, and organize training programs (courseware) for customers at CMXG. Created courseware and knowledge capture for on-the-job and computer-based training. Reviewed and improved previously developed courseware.",
                        Role = "Courseware Developer"
                    };

                    var JAAW = new Job
                    {
                        Title = "JAAW",
                        Location = "Hill AFB, UT",
                        Start = new DateTime(2022, 10, 1),
                        End = new DateTime(2023, 8, 1),
                        Summary = "Worked with a team of professionals to re engineer a tactical warfare simulation system. Developed a strong understanding of Agile Scrum methodologies. Successfully delivered high-quality deliverables to clients.",
                        Role = "Courseware Developer"
                    };

                    context.Role.Add(burgerKing);
                    context.Role.Add(farrBetterIceCream);
                    context.Role.Add(unitedWayOfNorthernUtah);
                    context.Role.Add(constellationSoftwareEngineering);
                    context.Role.Add(agovX);
                    context.Role.Add(JAAW);

                    // Add Contacts (Supervisors only for now)

                    // BK (Unavailable)
                    // Farrs (Unavailable)
                    // UWNU
                    var keniceWhitaker = new Contact
                    {
                        Name = "Kenice Whitaker",
                        Email = "kwitaker@uwnu.org",
                        PhoneNumber = "(801) 358-3393",
                        Title = "Program Director",
                        AssociatedJob = unitedWayOfNorthernUtah,
                        WasSupervisor = true,
                    };

                    // CSE (Unavailable)
                    // AgovX (Unavailable)
                    // JAAW (Unavailable)
                    var johnPeake = new Contact
                    {
                        Name = "John Peake",
                        PhoneNumber = "(321) 848-7272",
                        Title = "Team Lead",
                        AssociatedJob = JAAW,
                        WasSupervisor = true,
                    };

                    context.Contact.Add(keniceWhitaker);
                    context.Contact.Add(johnPeake);

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = burgerKing,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Prepared and cooked food according to recipes and standards.",
                            "Maintained a clean and sanitary work area.",
                            "Adhered to safety procedures.",
                        }),
                        Tag = "Food",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = burgerKing,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Cleaned and sanitized all kitchen equipment and surfaces.",
                            "Took out the trash and recycling.",
                            "Mopped and swept the floors.",
                        }),
                        Tag = "Cleaning",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = burgerKing,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Wore proper safety gear, such as gloves, hairnets, and aprons.",
                            "Washed hands frequently.",
                            "Disposed of waste properly.",
                        }),
                        Tag = "Safety",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = burgerKing,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Worked as part of a team to ensure efficient food preparation and service.",
                            "Communicated effectively with co-workers.",
                            "Helped out with tasks as needed.",
                        }),
                        Tag = "Teamwork",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = burgerKing,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Greeted customers in a friendly and professional manner.",
                            "Answered customer questions about the menu.",
                            "Took orders and processed payments.",
                            "Delivered food to customers.",
                            "Cleaned up tables and chairs.",
                        }),
                        Tag = "Customer service",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = burgerKing,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Assisted with inventory management.",
                            "Took inventory of food and supplies.",
                            "Handled customer complaints.",
                            "Cleaned and maintained the restaurant.",
                        }),
                        Tag = "Management",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = farrBetterIceCream,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Prepared and cooked food according to recipes and standards.",
                            "Maintained a clean and sanitary work area.",
                            "Adhered to safety procedures.",
                        }),
                        Tag = "Food",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = farrBetterIceCream,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Cleaned and sanitized all kitchen equipment and surfaces.",
                            "Took out the trash and recycling.",
                            "Mopped and swept the floors.",
                        }),
                        Tag = "Cleaning",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = farrBetterIceCream,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Wore proper safety gear, such as gloves, hairnets, and aprons.",
                            "Washed hands frequently.",
                            "Disposed of waste properly.",
                        }),
                        Tag = "Safety",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = farrBetterIceCream,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Worked as part of a team to ensure efficient food preparation and service.",
                            "Communicated effectively with co-workers.",
                            "Helped out with tasks as needed.",
                        }),
                        Tag = "Teamwork",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = farrBetterIceCream,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Greeted customers in a friendly and professional manner.",
                            "Answered customer questions about the menu.",
                            "Took orders and processed payments.",
                            "Delivered food to customers.",
                            "Cleaned up tables and chairs.",
                        }),
                        Tag = "Customer service",
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = farrBetterIceCream,
                        Experience = JsonSerializer.Serialize(new List<string>()
                        {
                            "Assisted with inventory management.",
                            "Took inventory of food and supplies.",
                            "Handled customer complaints.",
                            "Cleaned and maintained the restaurant.",
                        }),
                        Tag = "Management",
                    });

                    // JAAW
                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Problem-solving",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Developed 3 different algorithms for realistic tactical decision-making in warfare simulations.",
                            "Resolved hundreds of complex software bugs affecting the accuracy of simulation results.",
                            "Designed and implemented strategies for efficient resource management in simulations.",
                            "Optimized performance-critical simulation modules for real-time processing.",
                            "Evaluated and integrated third-party libraries to enhance simulation capabilities."
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Critical thinking",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Identified and addressed several potential security vulnerabilities in simulation systems.",
                            "Optimized codebase and increased the speed of the application by 35%",
                            "Assessed complex scenarios to simulate real-world tactical challenges effectively.",
                            "Evaluated and improved the overall architecture of the warfare simulation software.",
                            "Conducted in-depth analysis of simulation results to validate accuracy and realism.",
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Communication",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Collaborated with military experts to gather and refine simulation requirements.",
                            "Effectively communicated technical concepts to non-technical stakeholders in the defense sector.",
                            "Provided more than 35 project updates and demonstrated the impact of simulation improvements.",
                            "Drafted clear and concise technical documentation for simulation systems.",
                            "Facilitated discussions to align the development team with tactical simulation objectives."
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Teamwork",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Shared knowledge and collaborated with military strategists and software engineers.",
                            "Worked in interdisciplinary teams to ensure comprehensive warfare simulation capabilities.",
                            "Contributed to agile development processes, adapting to evolving military requirements.",
                            "Coordinated closely with fellow developers to integrate software components seamlessly.",
                            "Celebrated team achievements in delivering cutting-edge tactical simulations."
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Attention to detail",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Conducted meticulous testing and validation to ensure the accuracy of simulation results.",
                            "Maintained comprehensive documentation of simulation features and functionalities.",
                            "Identified and addressed subtle simulation errors to improve overall realism.",
                            "Adhered to strict coding standards and conducted thorough code reviews.",
                            "Implemented detailed simulation parameters to capture real-world nuances."
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Time management",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Effectively managed project timelines, ensuring on-time delivery of simulation enhancements.",
                            "Balanced multiple concurrent projects and prioritized tasks based on objectives.",
                            "Utilized time-tracking tools to optimize work hours for maximum productivity.",
                            "Adapted to changing tactical requirements while maintaining project schedules.",
                            "Demonstrated a strong sense of urgency and commitment to project timelines."
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Flexibility",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Adapted software components to accommodate evolving warfare strategies.",
                            "Embraced changes in military tactics and adjusted simulation parameters accordingly.",
                            "Successfully transitioned between different simulation scenarios and scenarios.",
                            "Handled unexpected technical challenges and issues with agility.",
                            "Thrived in dynamic and fast-paced military simulation environments."
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Learning agility",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                        "Rapidly acquired new military and simulation-related knowledge and technologies.",
                        "Proactively sought out military expertise to enhance simulation realism.",
                        "Applied newly acquired skills to create more accurate and effective simulations.",
                        "Mentored team members to expedite their learning curves in the defense sector.",
                        "Continuously improved skills through military and simulation-focused courses."
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Ability to work independently and as part of a team",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Independently developed C# class libraries that improved the functionality of over 6 different components within the simulation.",
                        "Trained more than 10 new hires and interns.",
                        "Effectively completed individual simulation modules with minimal supervision.",
                        "Balanced autonomy and teamwork based on the tactical requirements of each project.",
                        "Provided support and guidance to teammates when working on integrated simulation systems.",
                        "Adapted to both solo and collaborative work environments in the defense sector."
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Strong written and verbal communication skills",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Succinctly explained solutions to intricate bugs, problems and errors in over 50 documents.",
                        "Hosted over 5 different team wide meetings dicussing our trajactory and delegating tasks to peers.",
                        "Provided well-structured written reports and analysis of simulation results.",
                        "Facilitated productive discussions during development and military strategy meetings.",
                        "Crafted detailed and precise technical documentation for simulation components.",
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Ability to work under pressure and meet deadlines",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Successfully delivered 6 mission-critical software updates under tight military deadlines.",
                        "Maintained composure and decisiveness during high-pressure tactical simulations.",
                        "Prioritized tasks effectively to meet urgent military objectives and mission requirements.",
                        "Managed project stress with a solutions-oriented approach in military environments.",
                        "Adhered to project schedules and milestones in high-pressure defense simulations."
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Self-motivated and able to work independently",
                        Experience = JsonSerializer.Serialize(new List<string>
                        {
                            "Initiated independent research, and as a result, improved the speed of the application by 74%.",
                            "Proactively identified and resolved over 15 different complex technical challenges in military software.",
                            "Demonstrated strong self-discipline and a proactive work ethic in military projects.",
                            "Took ownership of simulation tasks and consistently delivered high-quality results.",
                            "Set personal goals for continuous improvement and career advancement in defense simulation.",
                        })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Desire to learn and grow",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Learned 3 different programming languages (React.js, React Native, Java) while maintaining the C# code base.",
                        "Received 2 different certifications surrounding the practice and execution of Scrum Agile methodology.",
                        "Actively sought feedback from military experts to refine simulation accuracy.",
                        "Set ambitious long-term career goals and pursued opportunities for advancement.",
                        "Maintained a growth mindset and encouraged innovation in military simulation technologies."
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = JAAW,
                        Tag = "Passion for technology",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Wrote more than 4,000 lines of code in C#.",
                        "Created and maintained over 45 C# project files.",
                        "Stayed at the forefront of military simulation technologies and innovations.",
                        "Participated in cutting-edge research projects to advance defense simulation capabilities.",
                        "Mentored junior developers to foster innovation and excellence in simulation software.",
                    })
                    });

                    // Skills for UWNU
                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Problem-solving",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Identified and resolved complex software bugs to improve system reliability.",
                        "Developed innovative solutions to optimize database performance.",
                        "Implemented algorithmic solutions to address efficiency challenges.",
                        "Analyzed user feedback to identify and address usability issues.",
                        "Collaborated with cross-functional teams to troubleshoot system issues."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Critical thinking",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Evaluated existing software architecture to identify potential improvements.",
                        "Conducted in-depth code reviews to identify logic errors and security vulnerabilities.",
                        "Designed and implemented robust error-handling mechanisms.",
                        "Assessed project requirements to make informed technical decisions.",
                        "Optimized codebase for enhanced system scalability."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Communication",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Effectively communicated technical concepts to non-technical stakeholders.",
                        "Collaborated with clients to gather and document project requirements.",
                        "Provided regular project updates to both technical and non-technical team members.",
                        "Drafted clear and concise technical documentation and reports.",
                        "Facilitated knowledge-sharing sessions within the development team."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Teamwork",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Worked closely with cross-functional teams to deliver complex projects.",
                        "Shared knowledge and expertise with team members to foster collaboration.",
                        "Resolved conflicts and promoted a positive team dynamic.",
                        "Contributed to agile development processes, including sprint planning and retrospectives.",
                        "Celebrated team achievements and promoted a culture of camaraderie."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Attention to detail",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Performed thorough code reviews to catch subtle errors and code quality issues.",
                        "Carefully tested and validated software components to ensure accuracy.",
                        "Maintained comprehensive project documentation with meticulous attention to detail.",
                        "Identified and fixed edge cases to enhance software robustness.",
                        "Ensured adherence to coding standards and best practices."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Time management",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Managed multiple concurrent projects with effective time allocation.",
                        "Set realistic project milestones and consistently met project deadlines.",
                        "Prioritized tasks based on project urgency and importance.",
                        "Utilized time-tracking tools to optimize work hours and productivity.",
                        "Adapted to changing project priorities while maintaining project schedules."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Flexibility",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Adapted to evolving project requirements and technology stacks.",
                        "Embraced change and adjusted project strategies as needed.",
                        "Successfully switched between different programming languages and frameworks.",
                        "Handled unexpected issues and obstacles with a flexible mindset.",
                        "Collaborated effectively in agile development environments."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Learning agility",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Quickly acquired new programming languages and technologies as needed.",
                        "Proactively sought out learning opportunities and resources.",
                        "Applied newly acquired skills to enhance project outcomes.",
                        "Mentored team members to accelerate their learning curves.",
                        "Continuously improved skills through online courses and self-study."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Ability to work independently and as part of a team",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Effectively completed solo projects with minimal supervision.",
                        "Collaborated seamlessly within development teams to achieve project goals.",
                        "Balanced autonomy and teamwork based on project requirements.",
                        "Provided support and guidance to teammates when working in groups.",
                        "Thrived in both solo and collaborative work environments."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Strong written and verbal communication skills",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Crafted clear and concise technical documentation.",
                        "Delivered compelling technical presentations to stakeholders.",
                        "Facilitated productive discussions during team meetings.",
                        "Provided well-structured written reports and project proposals.",
                        "Effectively communicated complex ideas to diverse audiences."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Ability to work under pressure and meet deadlines",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Successfully delivered high-quality software under tight project timelines.",
                        "Remained calm and focused during critical production incidents.",
                        "Prioritized tasks effectively to meet urgent project deadlines.",
                        "Managed project stress with a solutions-oriented mindset.",
                        "Adhered to project schedules and milestones in high-pressure situations."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Self-motivated and able to work independently",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Initiated and completed independent side projects outside of work.",
                        "Demonstrated strong self-discipline and work ethic.",
                        "Took ownership of tasks and consistently delivered results.",
                        "Set personal goals for skill development and career advancement.",
                        "Proactively identified and resolved technical challenges."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Desire to learn and grow",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Actively sought feedback to identify areas for improvement.",
                        "Engaged in continuous learning and professional development.",
                        "Participated in mentorship programs to accelerate growth.",
                        "Set long-term career goals and pursued opportunities for advancement.",
                        "Maintained a growth mindset and encouraged others to do the same."
                    }),
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = unitedWayOfNorthernUtah,
                        Tag = "Passion for technology",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Stayed updated with the latest software development trends and technologies.",
                        "Participated in hackathons and open-source projects outside of work.",
                        "Advocated for the adoption of innovative technologies within the team.",
                        "Demonstrated enthusiasm for exploring new tools and frameworks."
                    }),
                    });

                    // Courseware Developing position
                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Problem-solving",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Analyzed and resolved course development challenges",
                        "Identified issues in instructional materials and proposed solutions",
                        "Adapted courseware to address unexpected problems",
                        "Used creative problem-solving to improve course content",
                        "Collaborated with team to find innovative solutions"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Critical thinking",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Evaluated courseware design critically for effectiveness",
                        "Identified areas for improvement through critical analysis",
                        "Analyzed learner feedback to make data-driven decisions",
                        "Applied critical thinking to enhance learning experiences",
                        "Contributed valuable insights through thoughtful analysis"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Communication",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Communicated course design decisions to stakeholders",
                        "Collaborated with team members on project objectives",
                        "Explained complex concepts in learner-friendly terms",
                        "Provided clear instructions to instructors for course delivery",
                        "Facilitated productive discussions among team members"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Teamwork",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Collaborated with cross-functional teams on courseware development",
                        "Contributed to team-based course design efforts",
                        "Shared knowledge and insights with team members",
                        "Worked together to achieve course development goals",
                        "Supported team members in achieving project objectives"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Attention to detail",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Maintained a high level of accuracy in courseware development",
                        "Checked course materials for errors and inconsistencies",
                        "Followed meticulous course design processes",
                        "Ensured course quality through thorough review",
                        "Identified and corrected content anomalies"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Time management",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Managed time effectively to meet project deadlines",
                        "Prioritized tasks for efficient course development",
                        "Completed projects on schedule by effective time management",
                        "Balanced multiple tasks concurrently",
                        "Optimized work processes to save time"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Flexibility",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Adapted to evolving courseware development requirements",
                        "Handled unexpected challenges with flexibility",
                        "Pivoted quickly in response to changing project needs",
                        "Adjusted course design as necessary",
                        "Embraced change and remained adaptable"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Learning agility",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Rapidly acquired new course development tools and techniques",
                        "Continuously updated skills in instructional design",
                        "Eagerly embraced opportunities for learning",
                        "Quickly learned to work with new technologies",
                        "Applied new knowledge to improve course content"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Ability to work independently and as part of a team",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Worked independently on course development projects",
                        "Collaborated with a team on complex courseware tasks",
                        "Balanced individual contributions with teamwork",
                        "Adapted communication style based on project needs",
                        "Efficiently switched between independent and collaborative work"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Strong written and verbal communication skills",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Wrote clear and concise course materials",
                        "Delivered effective presentations to stakeholders",
                        "Communicated complex concepts in writing",
                        "Facilitated productive discussions through verbal communication",
                        "Conveyed insights through both written and spoken word"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Ability to work under pressure and meet deadlines",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Successfully completed projects under tight deadlines",
                        "Thrived in high-pressure courseware development situations",
                        "Maintained composure while working on time-sensitive tasks",
                        "Prioritized tasks effectively to meet urgent project needs",
                        "Delivered quality results under time constraints"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Self-motivated and able to work independently",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Initiated and completed projects independently",
                        "Took ownership of courseware tasks without constant supervision",
                        "Demonstrated self-motivation in pursuing project goals",
                        "Managed workload effectively without external pressure",
                        "Consistently met courseware development objectives"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Desire to learn and grow",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Pursued opportunities for skill development in instructional design",
                        "Actively sought out new challenges in course development",
                        "Demonstrated a commitment to personal and professional growth",
                        "Took on additional responsibilities to expand knowledge",
                        "Maintained a curious and inquisitive mindset toward learning"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "Passion for technology",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Kept up-to-date with the latest eLearning technologies",
                        "Demonstrated enthusiasm for integrating technology into courses",
                        "Applied technological advancements to enhance course materials",
                        "Shared tech insights and innovations with the team",
                        "Displayed a genuine passion for technology in education"
                    })
                    });

                    context.Experience.Add(new JobExperience
                    {
                        AssociatedJob = agovX,
                        Tag = "ADDIE Model",
                        Experience = JsonSerializer.Serialize(new List<string>
                    {
                        "Applied the ADDIE model (Analysis, Design, Development, Implementation, Evaluation) in course development",
                        "Followed ADDIE phases for systematic courseware creation",
                        "Iteratively improved courseware based on evaluation results",
                        "Ensured ADDIE principles were central to course development",
                        "Utilized ADDIE as a framework for continuous improvement"
                    })
                    });

                    // Save Changes.
                    //context.SaveChanges();
                    JobContext = context;
                }
                return (SudoJobContext)JobContext;
            }
        }
    }
}
