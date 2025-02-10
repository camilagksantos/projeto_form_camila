using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Business.Models;

namespace projeto_form_camila.Models;

public partial class BdProjetoFormCamilaContext : DbContext
{
    public BdProjetoFormCamilaContext()
    {
    }

    public BdProjetoFormCamilaContext(DbContextOptions<BdProjetoFormCamilaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Disciplina> Disciplinas { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<Turma> Turmas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=62.28.39.135,62444;Initial Catalog=bd_projeto_form_camila;User ID=EFACAMILA;Password=123.Abc##;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.IdAluno);

            entity.ToTable("aluno");

            entity.Property(e => e.IdAluno).HasColumnName("id_aluno");
            entity.Property(e => e.Apelido)
                .HasMaxLength(45)
                .HasColumnName("apelido");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Idade).HasColumnName("idade");
            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.Nome)
                .HasMaxLength(45)
                .HasColumnName("nome");
            entity.Property(e => e.TurmaId).HasColumnName("turma_id");

            entity.HasOne(d => d.Login).WithMany(p => p.Alunos)
                .HasForeignKey(d => d.LoginId)
                .HasConstraintName("FK_aluno_login");

            entity.HasOne(d => d.Turma).WithMany(p => p.Alunos)
                .HasForeignKey(d => d.TurmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_aluno_turma");
        });

        modelBuilder.Entity<Disciplina>(entity =>
        {
            entity.HasKey(e => e.IdDisciplina);

            entity.ToTable("disciplina");

            entity.Property(e => e.IdDisciplina).HasColumnName("id_disciplina");
            entity.Property(e => e.Designacao)
                .HasMaxLength(45)
                .HasColumnName("designacao");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.IdFuncionario);

            entity.ToTable("funcionario");

            entity.Property(e => e.IdFuncionario).HasColumnName("id_funcionario");
            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.Nome)
                .HasMaxLength(45)
                .HasColumnName("nome");

            entity.HasOne(d => d.Login).WithMany(p => p.Funcionarios)
                .HasForeignKey(d => d.LoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_funcionario_login");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.IdLogin);

            entity.ToTable("login");

            entity.HasIndex(e => e.Username, "UQ_login_user").IsUnique();

            entity.Property(e => e.IdLogin).HasColumnName("id_login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(45)
                .HasColumnName("role");
            entity.Property(e => e.Username)
                .HasMaxLength(45)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.HasKey(e => e.IdNota);

            entity.ToTable("nota");

            entity.Property(e => e.IdNota).HasColumnName("id_nota");
            entity.Property(e => e.AlunoId).HasColumnName("aluno_id");
            entity.Property(e => e.DataAtribuicao)
                .HasColumnType("datetime")
                .HasColumnName("data_atribuicao");
            entity.Property(e => e.DisciplinaId).HasColumnName("disciplina_id");
            entity.Property(e => e.ValorNota)
                .HasColumnType("decimal(30, 0)")
                .HasColumnName("valor_nota");

            entity.HasOne(d => d.Aluno).WithMany(p => p.Nota)
                .HasForeignKey(d => d.AlunoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_aluno");

            entity.HasOne(d => d.Disciplina).WithMany(p => p.Nota)
                .HasForeignKey(d => d.DisciplinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_disciplina");
        });

        modelBuilder.Entity<Turma>(entity =>
        {
            entity.HasKey(e => e.IdTurma);

            entity.ToTable("turma");

            entity.Property(e => e.IdTurma).HasColumnName("id_turma");
            entity.Property(e => e.Designacao)
                .HasMaxLength(45)
                .HasColumnName("designacao");
            entity.Property(e => e.ProfessorId).HasColumnName("professor_id");

            entity.HasOne(d => d.Professor).WithMany(p => p.Turmas)
                .HasForeignKey(d => d.ProfessorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_turma_funcionario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
